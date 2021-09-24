namespace NotasPrefeituraSP.Models.Sp.Sync.Nfes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe/tipos")]
    public partial class tpNFe
    {

        private byte[] assinaturaField;

        private tpChaveNFe chaveNFeField;

        private System.DateTime dataEmissaoNFeField;

        private long numeroLoteField;

        private bool numeroLoteFieldSpecified;

        private tpChaveRPS chaveRPSField;

        private tpTipoRPS tipoRPSField;

        private bool tipoRPSFieldSpecified;

        private System.DateTime dataEmissaoRPSField;

        private bool dataEmissaoRPSFieldSpecified;

        private tpCPFCNPJ cPFCNPJPrestadorField;

        private string razaoSocialPrestadorField;

        private tpEndereco enderecoPrestadorField;

        private string emailPrestadorField;

        private tpStatusNFe statusNFeField;

        private System.DateTime dataCancelamentoField;

        private bool dataCancelamentoFieldSpecified;

        private string tributacaoNFeField;

        private tpOpcaoSimples opcaoSimplesField;

        private long numeroGuiaField;

        private bool numeroGuiaFieldSpecified;

        private System.DateTime dataQuitacaoGuiaField;

        private bool dataQuitacaoGuiaFieldSpecified;

        private decimal valorServicosField;

        private decimal valorDeducoesField;

        private bool valorDeducoesFieldSpecified;

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

        private decimal valorISSField;

        private decimal valorCreditoField;

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

        private string iSSRetidoIntermediarioField;

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
            set
            {
                this.assinaturaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpChaveNFe ChaveNFe
        {
            get
            {
                return this.chaveNFeField;
            }
            set
            {
                this.chaveNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime DataEmissaoNFe
        {
            get
            {
                return this.dataEmissaoNFeField;
            }
            set
            {
                this.dataEmissaoNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long NumeroLote
        {
            get
            {
                return this.numeroLoteField;
            }
            set
            {
                this.numeroLoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroLoteSpecified
        {
            get
            {
                return this.numeroLoteFieldSpecified;
            }
            set
            {
                this.numeroLoteFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoRPSSpecified
        {
            get
            {
                return this.tipoRPSFieldSpecified;
            }
            set
            {
                this.tipoRPSFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DataEmissaoRPS
        {
            get
            {
                return this.dataEmissaoRPSField;
            }
            set
            {
                this.dataEmissaoRPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataEmissaoRPSSpecified
        {
            get
            {
                return this.dataEmissaoRPSFieldSpecified;
            }
            set
            {
                this.dataEmissaoRPSFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpCPFCNPJ CPFCNPJPrestador
        {
            get
            {
                return this.cPFCNPJPrestadorField;
            }
            set
            {
                this.cPFCNPJPrestadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RazaoSocialPrestador
        {
            get
            {
                return this.razaoSocialPrestadorField;
            }
            set
            {
                this.razaoSocialPrestadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpEndereco EnderecoPrestador
        {
            get
            {
                return this.enderecoPrestadorField;
            }
            set
            {
                this.enderecoPrestadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EmailPrestador
        {
            get
            {
                return this.emailPrestadorField;
            }
            set
            {
                this.emailPrestadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpStatusNFe StatusNFe
        {
            get
            {
                return this.statusNFeField;
            }
            set
            {
                this.statusNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime DataCancelamento
        {
            get
            {
                return this.dataCancelamentoField;
            }
            set
            {
                this.dataCancelamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCancelamentoSpecified
        {
            get
            {
                return this.dataCancelamentoFieldSpecified;
            }
            set
            {
                this.dataCancelamentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TributacaoNFe
        {
            get
            {
                return this.tributacaoNFeField;
            }
            set
            {
                this.tributacaoNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpOpcaoSimples OpcaoSimples
        {
            get
            {
                return this.opcaoSimplesField;
            }
            set
            {
                this.opcaoSimplesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long NumeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroGuiaSpecified
        {
            get
            {
                return this.numeroGuiaFieldSpecified;
            }
            set
            {
                this.numeroGuiaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DataQuitacaoGuia
        {
            get
            {
                return this.dataQuitacaoGuiaField;
            }
            set
            {
                this.dataQuitacaoGuiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataQuitacaoGuiaSpecified
        {
            get
            {
                return this.dataQuitacaoGuiaFieldSpecified;
            }
            set
            {
                this.dataQuitacaoGuiaFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorDeducoesSpecified
        {
            get
            {
                return this.valorDeducoesFieldSpecified;
            }
            set
            {
                this.valorDeducoesFieldSpecified = value;
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
            set
            {
                this.valorPISFieldSpecified = value;
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
            set
            {
                this.valorCOFINSFieldSpecified = value;
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
            set
            {
                this.valorINSSFieldSpecified = value;
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
            set
            {
                this.valorIRFieldSpecified = value;
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
            set
            {
                this.valorCSLLFieldSpecified = value;
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
        public decimal ValorISS
        {
            get
            {
                return this.valorISSField;
            }
            set
            {
                this.valorISSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorCredito
        {
            get
            {
                return this.valorCreditoField;
            }
            set
            {
                this.valorCreditoField = value;
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
            set
            {
                this.inscricaoMunicipalTomadorFieldSpecified = value;
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
            set
            {
                this.inscricaoEstadualTomadorFieldSpecified = value;
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
            set
            {
                this.inscricaoMunicipalIntermediarioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ISSRetidoIntermediario
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
            set
            {
                this.valorCargaTributariaFieldSpecified = value;
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
            set
            {
                this.percentualCargaTributariaFieldSpecified = value;
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
            set
            {
                this.codigoCEIFieldSpecified = value;
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
            set
            {
                this.matriculaObraFieldSpecified = value;
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
            set
            {
                this.municipioPrestacaoFieldSpecified = value;
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
            set
            {
                this.numeroEncapsulamentoFieldSpecified = value;
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
            set
            {
                this.valorTotalRecebidoFieldSpecified = value;
            }
        }
    }
}
