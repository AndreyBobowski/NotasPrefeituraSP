

using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models;
using NotasPrefeituraSP.Models.Sp.Sync.Nfes;
using System;

namespace NotasPrefeituraSP.Generators
{
    public class ConsultaCNPJGenerator : IMessageGenerator
    {
        private ClientSettings Settings;
        private string CPFCNPJ;
        private PedidoConsultaCNPJ ObjectGenerator;

        public ConsultaCNPJGenerator(long CPFCNPJ)
        {
            this.CPFCNPJ = CPFCNPJ.ToString();
        }

        public object GenerateMessageObject()
        {
            ObjectGenerator = new PedidoConsultaCNPJ();
            CreateObjectHeader();
            CreateObjectCPFCNPJ();

            return ObjectGenerator;
        }

        private void CreateObjectCPFCNPJ()
        {
            ObjectGenerator.CNPJContribuinte = new tpCPFCNPJ();
            ObjectGenerator.CNPJContribuinte.Item = CPFCNPJ;
        }

        private void CreateObjectHeader()
        {
            ObjectGenerator.Cabecalho = new PedidoConsultaCNPJCabecalho();
            ObjectGenerator.Cabecalho.CPFCNPJRemetente = new tpCPFCNPJ();
            ObjectGenerator.Cabecalho.CPFCNPJRemetente.Item = Settings.CPFCNPJRemetente;
            ObjectGenerator.Cabecalho.Versao = Settings.Versao;
        }

        public void SetSettings(ClientSettings Settings)
        {
            this.Settings = Settings;
        }
    }
}
