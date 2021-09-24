

using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models;
using NotasPrefeituraSP.Models.Sp.Sync.Nfes;
using System;

namespace NotasPrefeituraSP.Generators
{
    public class CancelamentoNFeGenerator : IMessageGenerator
    {
        private ClientSettings Settings;
        private tpChaveNFe[] ChavesNFe;
        private bool Transacao;
        private PedidoCancelamentoNFe ObjectGeneretor;

        public CancelamentoNFeGenerator(tpChaveNFe[] ChavesNFe, bool Transacao = true)
        {
            this.ChavesNFe = ChavesNFe;
            this.Transacao = Transacao;
        }

        public object GenerateMessageObject()
        {
            ObjectGeneretor = new PedidoCancelamentoNFe();
            CreateObjectHeader();
            CreateObjectDetalhes();

            return ObjectGeneretor;
        }

        private void CreateObjectDetalhes()
        {
            ObjectGeneretor.Detalhe = new PedidoCancelamentoNFeDetalhe[ChavesNFe.Length];
            for (int i = 0; i < ChavesNFe.Length; i++)
            {
                ObjectGeneretor.Detalhe[i] = CreateDetalhe(ChavesNFe[i]);
            }
        }

        private PedidoCancelamentoNFeDetalhe CreateDetalhe(tpChaveNFe ChaveNFe)
        {
            PedidoCancelamentoNFeDetalhe detalhe = new PedidoCancelamentoNFeDetalhe();
            detalhe.ChaveNFe = ChaveNFe;
            detalhe.AssinaturaCancelamento = Utils.SignUtils.SignRSASHA1Text($"{ChaveNFe.InscricaoPrestador.ToString().PadLeft(8, '0')}{ChaveNFe.CodigoVerificacao.ToString().PadLeft(12, '0')}", Settings.Certificate);
            return detalhe;
        }

        private void CreateObjectHeader()
        {
            ObjectGeneretor.Cabecalho = new PedidoCancelamentoNFeCabecalho();
            ObjectGeneretor.Cabecalho.CPFCNPJRemetente = new tpCPFCNPJ();
            ObjectGeneretor.Cabecalho.CPFCNPJRemetente.Item = Settings.CPFCNPJRemetente;
            ObjectGeneretor.Cabecalho.transacao = Transacao;
            ObjectGeneretor.Cabecalho.Versao = Settings.Versao;
        }

        public void SetSettings(ClientSettings Settings)
        {
            this.Settings = Settings;
        }
    }
}
