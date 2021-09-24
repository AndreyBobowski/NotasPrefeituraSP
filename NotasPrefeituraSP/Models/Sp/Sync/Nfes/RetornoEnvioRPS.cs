namespace NotasPrefeituraSP.Models.Sp.Sync.Nfes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe", IsNullable = false)]
    public partial class RetornoEnvioRPS
    {

        private RetornoEnvioRPSCabecalho cabecalhoField;

        private tpEvento[] alertaField;

        private tpEvento[] erroField;

        private tpChaveNFeRPS chaveNFeRPSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RetornoEnvioRPSCabecalho Cabecalho
        {
            get
            {
                return this.cabecalhoField;
            }
            set
            {
                this.cabecalhoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alerta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpEvento[] Alerta
        {
            get
            {
                return this.alertaField;
            }
            set
            {
                this.alertaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Erro", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpEvento[] Erro
        {
            get
            {
                return this.erroField;
            }
            set
            {
                this.erroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tpChaveNFeRPS ChaveNFeRPS
        {
            get
            {
                return this.chaveNFeRPSField;
            }
            set
            {
                this.chaveNFeRPSField = value;
            }
        }
    }
}
