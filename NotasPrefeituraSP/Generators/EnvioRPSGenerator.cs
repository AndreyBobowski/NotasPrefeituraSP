

using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models;
using NotasPrefeituraSP.Models.Sp.Sync.Nfes;
using System;

namespace NotasPrefeituraSP.Generators
{
    public class EnvioRPSGenerator : IMessageGenerator
    {
        private ClientSettings Settings;
        private tpRPS RPS;
        private PedidoEnvioRPS ObjectGenerator;

        public EnvioRPSGenerator(tpRPS RPS)
        {
            this.RPS = RPS;
        }

        public object GenerateMessageObject()
        {
            ObjectGenerator = new PedidoEnvioRPS();
            CreateObjectHeader();
            CreateObjectRPS();

            return ObjectGenerator;
        }

        private void CreateObjectRPS()
        {
            RPS.SetSign(Utils.SignUtils.SignRSASHA1Text(RPS.GenerateSignKey(), Settings.Certificate));
            ObjectGenerator.RPS = RPS;
        }

        private void CreateObjectHeader()
        {
            ObjectGenerator.Cabecalho = new PedidoEnvioRPSCabecalho();
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
