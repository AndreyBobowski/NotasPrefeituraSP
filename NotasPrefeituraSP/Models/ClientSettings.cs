using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Text;

namespace NotasPrefeituraSP.Models
{
    public class ClientSettings
    {
        private string cPFCNPJRemetente;
        private X509Certificate2 certificate;
        private int versao;

        public string CPFCNPJRemetente { get => cPFCNPJRemetente; set => cPFCNPJRemetente = Regex.Replace(value, "[^0-9]", ""); }
        public X509Certificate2 Certificate { get => certificate; set => certificate = value; }
        public int Versao { get => versao; set => versao = value; }

        public string TipoRemetente { get => cPFCNPJRemetente.Length == 14 ? "CNPJ" : "CPF"; }
    }
}
