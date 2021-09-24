namespace NotasPrefeituraSP.Models.Sp.Sync.Nfes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public partial class PedidoCancelamentoNFeDetalhe
    {

        private tpChaveNFe chaveNFeField;

        private byte[] assinaturaCancelamentoField;

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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] AssinaturaCancelamento
        {
            get
            {
                return this.assinaturaCancelamentoField;
            }
            set
            {
                this.assinaturaCancelamentoField = value;
            }
        }
    }
}
