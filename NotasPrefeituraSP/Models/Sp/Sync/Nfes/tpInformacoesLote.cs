namespace NotasPrefeituraSP.Models.Sp.Sync.Nfes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe/tipos")]
    public partial class tpInformacoesLote
    {

        private long numeroLoteField;

        private bool numeroLoteFieldSpecified;

        private long inscricaoPrestadorField;

        private tpCPFCNPJ cPFCNPJRemetenteField;

        private System.DateTime dataEnvioLoteField;

        private long qtdNotasProcessadasField;

        private long tempoProcessamentoField;

        private decimal valorTotalServicosField;

        private decimal valorTotalDeducoesField;

        private bool valorTotalDeducoesFieldSpecified;

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
        public long InscricaoPrestador
        {
            get
            {
                return this.inscricaoPrestadorField;
            }
            set
            {
                this.inscricaoPrestadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpCPFCNPJ CPFCNPJRemetente
        {
            get
            {
                return this.cPFCNPJRemetenteField;
            }
            set
            {
                this.cPFCNPJRemetenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime DataEnvioLote
        {
            get
            {
                return this.dataEnvioLoteField;
            }
            set
            {
                this.dataEnvioLoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long QtdNotasProcessadas
        {
            get
            {
                return this.qtdNotasProcessadasField;
            }
            set
            {
                this.qtdNotasProcessadasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long TempoProcessamento
        {
            get
            {
                return this.tempoProcessamentoField;
            }
            set
            {
                this.tempoProcessamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorTotalServicos
        {
            get
            {
                return this.valorTotalServicosField;
            }
            set
            {
                this.valorTotalServicosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ValorTotalDeducoes
        {
            get
            {
                return this.valorTotalDeducoesField;
            }
            set
            {
                this.valorTotalDeducoesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorTotalDeducoesSpecified
        {
            get
            {
                return this.valorTotalDeducoesFieldSpecified;
            }
            set
            {
                this.valorTotalDeducoesFieldSpecified = value;
            }
        }
    }
}
