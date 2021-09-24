using NotasPrefeituraSP.Generators;
using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models;
using PrefeituraSPNotaSincrono;
using System.Security.Cryptography.X509Certificates;

namespace NotasPrefeituraSP
{
    public abstract class NotasPrefeituraSPClientBase
    {
        protected LoteNFeSoapClient loteNFeSoapClient;
        private MessageGenerator messageGenerator;
        protected ClientSettings Settings;



        /// <summary>
        /// Create NotasPrefeituraSPClient with certificate to sign XML and send requests
        /// </summary>
        /// <param name="Certificate">Certificate to sign XMLS and send requests.</param>
        public NotasPrefeituraSPClientBase(X509Certificate2 Certificate, string CPFCNPJRemetente)
        {
            CreateSettings(Certificate, CPFCNPJRemetente);
            messageGenerator = new MessageGenerator(Settings);
            loteNFeSoapClient = new LoteNFeSoapClient(LoteNFeSoapClient.EndpointConfiguration.LoteNFeSoap, GetCertificate());
        }


        /// <summary>
        /// Get Certificate
        /// </summary>
        /// <returns>Certificate in use</returns>
        protected X509Certificate2 GetCertificate()
        {
            return Settings.Certificate;
        }

        /// <summary>
        /// Generate message from an generator
        /// </summary>
        /// <param name="Generator">Generator that create de message</param>
        /// <returns></returns>
        protected string GenerateMessage(IMessageGenerator Generator)
        {
            Generator.SetSettings(Settings);
            return messageGenerator.GenerateMessage(Generator);
        }

        /// <summary>
        /// Create settings
        /// </summary>
        /// <param name="Certificate"></param>
        /// <param name="CPFCNPJRemetente"></param>
        private void CreateSettings(X509Certificate2 Certificate, string CPFCNPJRemetente)
        {
            Settings = new ClientSettings
            {
                Versao = 1,
                Certificate = Certificate,
                CPFCNPJRemetente = CPFCNPJRemetente
            };
        }
    }

}
