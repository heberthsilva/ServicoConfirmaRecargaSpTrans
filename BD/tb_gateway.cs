//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicoConfirmaRecargaSpTrans.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_gateway
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_gateway()
        {
            this.tb_chave_pix = new HashSet<tb_chave_pix>();
            this.tb_forma_pagamento = new HashSet<tb_forma_pagamento>();
            this.tb_gateway_fastcash = new HashSet<tb_gateway_fastcash>();
            this.tb_operadora_forma_pagamento_gateway = new HashSet<tb_operadora_forma_pagamento_gateway>();
            this.tb_parametro_parcelamento = new HashSet<tb_parametro_parcelamento>();
            this.tb_pedido = new HashSet<tb_pedido>();
            this.tb_usuario_cartao_credito_gateway_token = new HashSet<tb_usuario_cartao_credito_gateway_token>();
        }
    
        public short cd_gateway { get; set; }
        public string nm_gateway { get; set; }
        public string ds_tipo_autorizacao { get; set; }
        public string ds_site_autorizacao { get; set; }
        public string ds_token_autorizacao { get; set; }
        public string nm_usuario { get; set; }
        public string nm_senha { get; set; }
        public string ds_site_autorizacao_recurring { get; set; }
        public string ds_site { get; set; }
        public string ds_url_retorno { get; set; }
        public string ds_token_retorno { get; set; }
        public string ds_url_webhook { get; set; }
        public Nullable<bool> ic_processamento_operadora { get; set; }
        public string ds_token_autorizacao_max { get; set; }
        public Nullable<System.DateTime> dt_validade_token { get; set; }
        public string ds_token_max { get; set; }
        public string ds_app_key { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_chave_pix> tb_chave_pix { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_forma_pagamento> tb_forma_pagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_gateway_fastcash> tb_gateway_fastcash { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_operadora_forma_pagamento_gateway> tb_operadora_forma_pagamento_gateway { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_parametro_parcelamento> tb_parametro_parcelamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido> tb_pedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cartao_credito_gateway_token> tb_usuario_cartao_credito_gateway_token { get; set; }
    }
}
