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
    
    public partial class tb_usuario_cartao_credito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_usuario_cartao_credito()
        {
            this.tb_recarga_automatica = new HashSet<tb_recarga_automatica>();
            this.tb_recarga_programada = new HashSet<tb_recarga_programada>();
            this.tb_usuario_cartao_credito_endereco_cobranca = new HashSet<tb_usuario_cartao_credito_endereco_cobranca>();
            this.tb_usuario_cartao_credito_gateway_token = new HashSet<tb_usuario_cartao_credito_gateway_token>();
        }
    
        public long cd_usuario_cartao_credito { get; set; }
        public long cd_usuario { get; set; }
        public string ds_bandeira_cartao_credito { get; set; }
        public string ds_cartao_credito { get; set; }
        public string ds_nome_cartao_credito { get; set; }
        public string ds_mes_cartao_credito { get; set; }
        public string ds_ano_cartao_credito { get; set; }
        public string ds_cartao_credito_chave { get; set; }
        public string ds_ultimos_digitos { get; set; }
        public string ds_primeiros_digitos { get; set; }
        public Nullable<bool> ic_inativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_recarga_automatica> tb_recarga_automatica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_recarga_programada> tb_recarga_programada { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cartao_credito_endereco_cobranca> tb_usuario_cartao_credito_endereco_cobranca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cartao_credito_gateway_token> tb_usuario_cartao_credito_gateway_token { get; set; }
    }
}
