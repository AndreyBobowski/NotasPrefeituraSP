using NotasPrefeituraSP.Generators;
using NotasPrefeituraSP.Interfaces;
using NotasPrefeituraSP.Models.Sp.Sync.Nfes;
using NotasPrefeituraSP.Xml;
using PrefeituraSPNotaSincrono;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System;

namespace NotasPrefeituraSP
{
    public partial class NotasPrefeituraSPClient : NotasPrefeituraSPClientBase
    {

        public NotasPrefeituraSPClient(X509Certificate2 Certificate, string CPFCNPJRemetente) : base(Certificate, CPFCNPJRemetente)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ChavesNFe">Lista de ChavesNFe das notas que devem ser canceladas</param>
        /// <param name="Transacao">Determina se todas notas devem fazer parte de uma mesma transação, se sim caso ocorra erro em algum cancelamento nenhuma nota será cancelada. default:true</param>
        /// <returns>RetornoCancelamentoNFe contem o status ou erros e alertas do resultado da transação</returns>
        public RetornoCancelamentoNFe CancelamentoNFe(tpChaveNFe[] ChavesNFe, bool Transacao = true)
        {
            IMessageGenerator generator = new CancelamentoNFeGenerator(ChavesNFe, Transacao);
            CancelamentoNFeResponse response = loteNFeSoapClient.CancelamentoNFeAsync(Settings.Versao, GenerateMessage(generator)).Result;
            XmlResponseParser<RetornoCancelamentoNFe> responseParser = new XmlResponseParser<RetornoCancelamentoNFe>();

            return responseParser.ParseXML(response.RetornoXML);
        }

        /// <summary>
        /// Consulta CNPJ ou CPF
        /// </summary>
        /// <param name="CPFCNPJ">Inscrição a ser consultada</param>
        /// <returns>Dados da consulta</returns>
        public RetornoConsultaCNPJ ConsultaCNPJ(long CPFCNPJ)
        {
            IMessageGenerator generator = new ConsultaCNPJGenerator(CPFCNPJ);
            ConsultaCNPJResponse response = loteNFeSoapClient.ConsultaCNPJAsync(Settings.Versao, GenerateMessage(generator)).Result;
            XmlResponseParser<RetornoConsultaCNPJ> responseParser = new XmlResponseParser<RetornoConsultaCNPJ>();

            return responseParser.ParseXML(response.RetornoXML);
        }

        /// <summary>
        /// Envio de RPS Única
        /// </summary>
        /// <param name="RPS">Objeto contendo dados de uma RPS</param>
        /// <returns>Dados da consulta</returns>
        public RetornoEnvioRPS EnvioRPS(tpRPS RPS)
        {
            IMessageGenerator generator = new EnvioRPSGenerator(RPS);
            EnvioRPSResponse response = loteNFeSoapClient.EnvioRPSAsync(Settings.Versao, GenerateMessage(generator)).Result;
            XmlResponseParser<RetornoEnvioRPS> responseParser = new XmlResponseParser<RetornoEnvioRPS>();

            return responseParser.ParseXML(response.RetornoXML);
        }

        /// <summary>
        /// Envio de RPS em Lote
        /// </summary>
        /// <param name="RPSArray">Objeto contendo dados de uma lista de RPS</param>
        /// <param name="Transacao">Determina se todas notas devem fazer parte de uma mesma transação, se sim caso ocorra erro em algum cancelamento nenhuma nota será cancelada. default:true</param>
        /// <returns>Dados da consulta</returns>
        public RetornoEnvioLoteRPS EnvioLoteRPS(tpRPS[] RPSArray, bool Transacao = true)
        {
            IMessageGenerator generator = new EnvioLoteRPSGenerator(RPSArray);
            EnvioLoteRPSResponse response = loteNFeSoapClient.EnvioLoteRPSAsync(Settings.Versao, GenerateMessage(generator)).Result;
            XmlResponseParser<RetornoEnvioLoteRPS> responseParser = new XmlResponseParser<RetornoEnvioLoteRPS>();

            return responseParser.ParseXML(response.RetornoXML);
        }

        /// <summary>
        /// Envio de RPS em Lote Teste o webservice apenas fará as validações, nenhuma nota setá gerada ao final do processo.
        /// </summary>
        /// <param name="RPSArray">Objeto contendo dados de uma lista de RPS</param>
        /// <param name="Transacao">Determina se todas notas devem fazer parte de uma mesma transação, se sim caso ocorra erro em algum cancelamento nenhuma nota será cancelada. default:true</param>
        /// <returns>Dados da consulta</returns>
        public RetornoEnvioLoteRPS TesteEnvioLoteRPS(tpRPS[] RPSArray, bool Transacao = true)
        {
            IMessageGenerator generator = new EnvioLoteRPSGenerator(RPSArray);
            TesteEnvioLoteRPSResponse response = loteNFeSoapClient.TesteEnvioLoteRPSAsync(Settings.Versao, GenerateMessage(generator)).Result;
            XmlResponseParser<RetornoEnvioLoteRPS> responseParser = new XmlResponseParser<RetornoEnvioLoteRPS>();

            return responseParser.ParseXML(response.RetornoXML);
        }
    }
}
