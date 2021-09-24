namespace NotasPrefeituraSP.Models.Sp.Sync.Nfes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe/tipos")]
    public partial class tpRPS
    {

        private byte[] assinaturaField;

        private tpChaveRPS chaveRPSField;

        private tpTipoRPS tipoRPSField;

        private System.DateTime dataEmissaoField;

        private tpStatusNFe statusRPSField;

        private string tributacaoRPSField;

        private decimal valorServicosField;

        private decimal valorDeducoesField;

        private decimal valorPISField;

        private bool valorPISFieldSpecified;

        private decimal valorCOFINSField;

        private bool valorCOFINSFieldSpecified;

        private decimal valorINSSField;

        private bool valorINSSFieldSpecified;

        private decimal valorIRField;

        private bool valorIRFieldSpecified;

        private decimal valorCSLLField;

        private bool valorCSLLFieldSpecified;

        private int codigoServicoField;

        private decimal aliquotaServicosField;

        private bool iSSRetidoField;

        private tpCPFCNPJ cPFCNPJTomadorField;

        private long inscricaoMunicipalTomadorField;

        private bool inscricaoMunicipalTomadorFieldSpecified;

        private long inscricaoEstadualTomadorField;

        private bool inscricaoEstadualTomadorFieldSpecified;

        private string razaoSocialTomadorField;

        private tpEndereco enderecoTomadorField;

        private string emailTomadorField;

        private tpCPFCNPJ cPFCNPJIntermediarioField;

        private long inscricaoMunicipalIntermediarioField;

        private bool inscricaoMunicipalIntermediarioFieldSpecified;

        private bool iSSRetidoIntermediarioField;

        private string emailIntermediarioField;

        private string discriminacaoField;

        private decimal valorCargaTributariaField;

        private bool valorCargaTributariaFieldSpecified;

        private decimal percentualCargaTributariaField;

        private bool percentualCargaTributariaFieldSpecified;

        private string fonteCargaTributariaField;

        private long codigoCEIField;

        private bool codigoCEIFieldSpecified;

        private long matriculaObraField;

        private bool matriculaObraFieldSpecified;

        private int municipioPrestacaoField;

        private bool municipioPrestacaoFieldSpecified;

        private long numeroEncapsulamentoField;

        private bool numeroEncapsulamentoFieldSpecified;

        private decimal valorTotalRecebidoField;

        private bool valorTotalRecebidoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] Assinatura
        {
            get
            {
                return this.assinaturaField;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpChaveRPS ChaveRPS
        {
            get
            {
                return this.chaveRPSField;
            }
            set
            {
                this.chaveRPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpTipoRPS TipoRPS
        {
            get
            {
                return this.tipoRPSField;
            }
            set
            {
                this.tipoRPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DataEmissao
        {
            get
            {
                return this.dataEmissaoField;
            }
            set
            {
                this.dataEmissaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpStatusNFe StatusRPS
        {
            get
            {
                return this.statusRPSField;
            }
            set
            {
                this.statusRPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TributacaoRPS
        {
            get
            {
                return this.tributacaoRPSField;
            }
            set
            {
                this.tributacaoRPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorServicos
        {
            get
            {
                return this.valorServicosField;
            }
            set
            {
                this.valorServicosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorDeducoes
        {
            get
            {
                return this.valorDeducoesField;
            }
            set
            {
                this.valorDeducoesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorPIS
        {
            get
            {
                return this.valorPISField;
            }
            set
            {
                this.valorPISFieldSpecified = true;
                this.valorPISField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorPISSpecified
        {
            get
            {
                return this.valorPISFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorCOFINS
        {
            get
            {
                return this.valorCOFINSField;
            }
            set
            {
                this.valorCOFINSFieldSpecified = true;
                this.valorCOFINSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCOFINSSpecified
        {
            get
            {
                return this.valorCOFINSFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorINSS
        {
            get
            {
                return this.valorINSSField;
            }
            set
            {
                this.valorINSSFieldSpecified = true;
                this.valorINSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorINSSSpecified
        {
            get
            {
                return this.valorINSSFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorIR
        {
            get
            {
                return this.valorIRField;
            }
            set
            {
                this.valorIRFieldSpecified = true;
                this.valorIRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorIRSpecified
        {
            get
            {
                return this.valorIRFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorCSLL
        {
            get
            {
                return this.valorCSLLField;
            }
            set
            {
                this.valorCSLLFieldSpecified = true;
                this.valorCSLLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCSLLSpecified
        {
            get
            {
                return this.valorCSLLFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int CodigoServico
        {
            get
            {
                return this.codigoServicoField;
            }
            set
            {
                this.codigoServicoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal AliquotaServicos
        {
            get
            {
                return this.aliquotaServicosField;
            }
            set
            {
                this.aliquotaServicosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ISSRetido
        {
            get
            {
                return this.iSSRetidoField;
            }
            set
            {
                this.iSSRetidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpCPFCNPJ CPFCNPJTomador
        {
            get
            {
                return this.cPFCNPJTomadorField;
            }
            set
            {
                this.cPFCNPJTomadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long InscricaoMunicipalTomador
        {
            get
            {
                return this.inscricaoMunicipalTomadorField;
            }
            set
            {
                this.inscricaoMunicipalIntermediarioFieldSpecified = true;
                this.inscricaoMunicipalTomadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoMunicipalTomadorSpecified
        {
            get
            {
                return this.inscricaoMunicipalTomadorFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long InscricaoEstadualTomador
        {
            get
            {
                return this.inscricaoEstadualTomadorField;
            }
            set
            {
                this.inscricaoEstadualTomadorFieldSpecified = true;
                this.inscricaoEstadualTomadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoEstadualTomadorSpecified
        {
            get
            {
                return this.inscricaoEstadualTomadorFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RazaoSocialTomador
        {
            get
            {
                return this.razaoSocialTomadorField;
            }
            set
            {
                this.razaoSocialTomadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpEndereco EnderecoTomador
        {
            get
            {
                return this.enderecoTomadorField;
            }
            set
            {
                this.enderecoTomadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EmailTomador
        {
            get
            {
                return this.emailTomadorField;
            }
            set
            {
                this.emailTomadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpCPFCNPJ CPFCNPJIntermediario
        {
            get
            {
                return this.cPFCNPJIntermediarioField;
            }
            set
            {
                this.cPFCNPJIntermediarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long InscricaoMunicipalIntermediario
        {
            get
            {
                return this.inscricaoMunicipalIntermediarioField;
            }
            set
            {
                this.inscricaoMunicipalIntermediarioFieldSpecified = true;
                this.inscricaoMunicipalIntermediarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoMunicipalIntermediarioSpecified
        {
            get
            {
                return this.inscricaoMunicipalIntermediarioFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ISSRetidoIntermediario
        {
            get
            {
                return this.iSSRetidoIntermediarioField;
            }
            set
            {
                this.iSSRetidoIntermediarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EmailIntermediario
        {
            get
            {
                return this.emailIntermediarioField;
            }
            set
            {
                this.emailIntermediarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Discriminacao
        {
            get
            {
                return this.discriminacaoField;
            }
            set
            {
                this.discriminacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorCargaTributaria
        {
            get
            {
                return this.valorCargaTributariaField;
            }
            set
            {
                this.valorCargaTributariaFieldSpecified = true;
                this.valorCargaTributariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCargaTributariaSpecified
        {
            get
            {
                return this.valorCargaTributariaFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal PercentualCargaTributaria
        {
            get
            {
                return this.percentualCargaTributariaField;
            }
            set
            {
                this.percentualCargaTributariaFieldSpecified = true;
                this.percentualCargaTributariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentualCargaTributariaSpecified
        {
            get
            {
                return this.percentualCargaTributariaFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FonteCargaTributaria
        {
            get
            {
                return this.fonteCargaTributariaField;
            }
            set
            {
                this.fonteCargaTributariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long CodigoCEI
        {
            get
            {
                return this.codigoCEIField;
            }
            set
            {
                this.codigoCEIFieldSpecified = true;
                this.codigoCEIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodigoCEISpecified
        {
            get
            {
                return this.codigoCEIFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long MatriculaObra
        {
            get
            {
                return this.matriculaObraField;
            }
            set
            {
                this.matriculaObraFieldSpecified = true;
                this.matriculaObraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatriculaObraSpecified
        {
            get
            {
                return this.matriculaObraFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int MunicipioPrestacao
        {
            get
            {
                return this.municipioPrestacaoField;
            }
            set
            {
                this.municipioPrestacaoFieldSpecified = true;
                this.municipioPrestacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MunicipioPrestacaoSpecified
        {
            get
            {
                return this.municipioPrestacaoFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long NumeroEncapsulamento
        {
            get
            {
                return this.numeroEncapsulamentoField;
            }
            set
            {
                this.numeroEncapsulamentoFieldSpecified = true;
                this.numeroEncapsulamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroEncapsulamentoSpecified
        {
            get
            {
                return this.numeroEncapsulamentoFieldSpecified;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorTotalRecebido
        {
            get
            {
                return this.valorTotalRecebidoField;
            }
            set
            {
                this.valorTotalRecebidoFieldSpecified = true;
                this.valorTotalRecebidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorTotalRecebidoSpecified
        {
            get
            {
                return this.valorTotalRecebidoFieldSpecified;
            }
        }


        public string GenerateSignKey()
        {
            string chave = "";
            chave += this.chaveRPSField.InscricaoPrestador.ToString().PadLeft(8, '0');
            chave += this.chaveRPSField.SerieRPS.PadRight(5, ' ');
            chave += this.chaveRPSField.NumeroRPS.ToString().PadLeft(12, '0');
            chave += this.dataEmissaoField.ToString("yyyyMMdd");
            chave += this.tributacaoRPSField;
            chave += this.statusRPSField;
            chave += this.ISSRetido ? "S" : "N";
            chave += this.valorServicosField.ToString("n2").Replace(".", "").Replace(",", "").PadLeft(15, '0');
            chave += this.codigoServicoField.ToString().PadLeft(5, '0');
            chave += this.cPFCNPJTomadorField == null ? 3 : this.cPFCNPJTomadorField.ItemActualType == ItemChoiceType.CPF ? 1 : 2;
            chave += (this.cPFCNPJTomadorField == null ? string.Empty : this.cPFCNPJTomadorField.Item).PadLeft(14, '0');
            chave += this.cPFCNPJIntermediarioField == null ? 3 : this.cPFCNPJIntermediarioField.ItemActualType == ItemChoiceType.CPF ? 1 : 2;
            chave += (this.cPFCNPJIntermediarioField == null ? string.Empty : this.cPFCNPJIntermediarioField.Item).PadLeft(14, '0');
            chave += this.iSSRetidoIntermediarioField ? "S" : "N";

            return chave;
        }

        public void SetSign(byte[] Sign)
        {
            this.assinaturaField = Sign;
        }
    }
}
