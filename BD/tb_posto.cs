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
    
    public partial class tb_posto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_posto()
        {
            this.tb_pedido_item_cartao = new HashSet<tb_pedido_item_cartao>();
            this.tb_posto_operadora = new HashSet<tb_posto_operadora>();
        }
    
        public int cd_posto { get; set; }
        public string ds_posto { get; set; }
        public string nu_posto_ddd_telefone { get; set; }
        public string nu_posto_telefone { get; set; }
        public string ds_posto_tipo_logradouro { get; set; }
        public string nm_posto_logradouro { get; set; }
        public int nu_posto_logradouro { get; set; }
        public string ds_posto_complemento_logradouro { get; set; }
        public string nm_posto_bairro { get; set; }
        public string nm_posto_municipio { get; set; }
        public short cd_uf { get; set; }
        public string nu_posto_cep { get; set; }
        public bool ic_posto_padrao { get; set; }
        public bool ic_posto_inativo { get; set; }
        public string cod_posto_parceiro_logistico { get; set; }
        public string ds_entrega_primeira_via { get; set; }
        public string ds_retirada_primeira_via { get; set; }
        public string ds_entrega_segunda_via { get; set; }
        public string ds_retirada_segunda_via { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_item_cartao> tb_pedido_item_cartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_posto_operadora> tb_posto_operadora { get; set; }
    }
}
