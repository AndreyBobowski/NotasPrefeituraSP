using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NotasPrefeituraSP.Xml
{
    class XmlResponseParser<ParseType>
    {
        public ParseType ParseXML(string Text)
        {
            using(TextReader reader = new StringReader(Text))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ParseType));
                return (ParseType)serializer.Deserialize(reader);
            }
        }
    }
}
