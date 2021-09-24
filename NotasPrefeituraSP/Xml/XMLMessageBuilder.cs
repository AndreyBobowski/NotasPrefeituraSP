using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NotasPrefeituraSP.Xml
{
    public class XMLMessageBuilder
    {
        private object Object;
        private X509Certificate2 Certificate;
        private XmlDocument Document;
        private string Message;

        /// <summary>
        /// Create XML and sign to send in soap request
        /// </summary>
        /// <param name="Obj">Object to serialize</param>
        /// <param name="Certificate">Certificate to sign</param>
        public XMLMessageBuilder(object Obj, X509Certificate2 Certificate)
        {
            this.Object = Obj;
            this.Certificate = Certificate;
            CreateXMLDocument();
        }

        private void CreateXMLDocument()
        {
            Document = new XmlDocument();
            SerializeObjectAndWriteDocument();
            SignDocument();
            CreateMessageString();
        }

        private void SerializeObjectAndWriteDocument()
        {
            using (XmlWriter writer = Document.CreateNavigator().AppendChild())
            {
                XmlSerializer ser = new XmlSerializer(Object.GetType());
                ser.Serialize(writer, Object);
            }
        }

        private void SignDocument()
        {
            SignedXml signedXml = new SignedXml(Document);
            signedXml.SigningKey = Certificate.GetRSAPrivateKey();
            Reference reference = new Reference();
            reference.Uri = "";
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);
            reference.AddTransform(new XmlDsigC14NTransform());
            signedXml.AddReference(reference);
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(Certificate));
            signedXml.KeyInfo = keyInfo;
            signedXml.ComputeSignature();
            XmlElement xmlDigitalSignature = signedXml.GetXml();
            Document.DocumentElement.AppendChild(Document.ImportNode(xmlDigitalSignature, true));
        }

        private void CreateMessageString()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;
                settings.Indent = false;
                settings.Encoding = Encoding.UTF8;
                using (XmlWriter wr = XmlWriter.Create(ms, settings))
                {

                    Document.Save(wr);
                }
                Message = Encoding.UTF8.GetString(ms.ToArray()).Remove(0, 1);
            }
        }
        public string GetXMLMessageString()
        {
            return Message;
        }

        public override string ToString()
        {
            return GetXMLMessageString();
        }
    }
}
