namespace NotasPrefeituraSP.Models.Sp.Sync.Nfes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public partial class PedidoConsultaNFePeriodoCabecalho
    {

        private tpCPFCNPJ cPFCNPJRemetenteField;

        private tpCPFCNPJ cPFCNPJField;

        private long inscricaoField;

        private bool inscricaoFieldSpecified;

        private System.DateTime dtInicioField;

        private System.DateTime dtFimField;

        private long numeroPaginaField;

        private long versaoField;

        public PedidoConsultaNFePeriodoCabecalho()
        {
            this.numeroPaginaField = ((long)(1));
            this.versaoField = ((long)(1));
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
        public tpCPFCNPJ CPFCNPJ
        {
            get
            {
                return this.cPFCNPJField;
            }
            set
            {
                this.cPFCNPJField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long Inscricao
        {
            get
            {
                return this.inscricaoField;
            }
            set
            {
                this.inscricaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoSpecified
        {
            get
            {
                return this.inscricaoFieldSpecified;
            }
            set
            {
                this.inscricaoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime dtInicio
        {
            get
            {
                return this.dtInicioField;
            }
            set
            {
                this.dtInicioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime dtFim
        {
            get
            {
                return this.dtFimField;
            }
            set
            {
                this.dtFimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long NumeroPagina
        {
            get
            {
                return this.numeroPaginaField;
            }
            set
            {
                this.numeroPaginaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long Versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }
}
