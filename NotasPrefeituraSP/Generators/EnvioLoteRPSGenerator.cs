

using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models;
using NotasPrefeituraSP.Models.Sp.Sync.Nfes;
using System;
using System.Linq;

namespace NotasPrefeituraSP.Generators
{
    public class EnvioLoteRPSGenerator : IMessageGenerator
    {
        private ClientSettings Settings;
        private tpRPS[] RPSArray;
        private bool Transacao;
        private PedidoEnvioLoteRPS ObjectGenerator;

        public EnvioLoteRPSGenerator(tpRPS[] RPSArray, bool Transacao = true)
        {
            this.RPSArray = RPSArray;
            this.Transacao = Transacao;
        }

        public object GenerateMessageObject()
        {
            ObjectGenerator = new PedidoEnvioLoteRPS();
            CreateObjectHeader();
            CreateObjectRPS();

            return ObjectGenerator;
        }

        private void CreateObjectRPS()
        {
            foreach(var RPS in RPSArray)
            {
                RPS.SetSign(Utils.SignUtils.SignRSASHA1Text(RPS.GenerateSignKey(), Settings.Certificate));
            }
            ObjectGenerator.RPS = RPSArray;
        }

        private void CreateObjectHeader()
        {
            ObjectGenerator.Cabecalho = new PedidoEnvioLoteRPSCabecalho();
            ObjectGenerator.Cabecalho.CPFCNPJRemetente = new tpCPFCNPJ();
            ObjectGenerator.Cabecalho.CPFCNPJRemetente.Item = Settings.CPFCNPJRemetente;
            ObjectGenerator.Cabecalho.transacao = Transacao;
            ObjectGenerator.Cabecalho.Versao = Settings.Versao;
            ObjectGenerator.Cabecalho.dtInicio = DateTime.Now;
            ObjectGenerator.Cabecalho.dtFim = DateTime.Now;
            ObjectGenerator.Cabecalho.QtdRPS = RPSArray.Length;
            ObjectGenerator.Cabecalho.ValorTotalServicos = RPSArray.Sum(rps => rps.ValorServicos);
            ObjectGenerator.Cabecalho.ValorTotalDeducoes = RPSArray.Sum(rps => rps.ValorDeducoes);
        }

        public void SetSettings(ClientSettings Settings)
        {
            this.Settings = Settings;
        }
    }
}
