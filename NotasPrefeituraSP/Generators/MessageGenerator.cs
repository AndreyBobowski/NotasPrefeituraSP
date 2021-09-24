using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models;
using NotasPrefeituraSP.Xml;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NotasPrefeituraSP.Generators
{
    public class MessageGenerator
    {
        private ClientSettings Settings; 

        public MessageGenerator(ClientSettings Settings)
        {
            this.Settings = Settings;
        }
        public string GenerateMessage(IMessageGenerator Generator)
        {
            Generator.SetSettings(Settings);
            XMLMessageBuilder builder = new XMLMessageBuilder(Generator.GenerateMessageObject(), Settings.Certificate);
            return builder.ToString();
        }
    }
}
