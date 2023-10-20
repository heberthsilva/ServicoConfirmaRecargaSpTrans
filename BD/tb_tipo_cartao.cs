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
    
    public partial class tb_tipo_cartao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_tipo_cartao()
        {
            this.tb_black_list = new HashSet<tb_black_list>();
            this.tb_operadora_empresa_tipo_cartao = new HashSet<tb_operadora_empresa_tipo_cartao>();
            this.tb_parametro_cashback = new HashSet<tb_parametro_cashback>();
            this.tb_parametro_revenda_comissao = new HashSet<tb_parametro_revenda_comissao>();
            this.tb_pedido_item = new HashSet<tb_pedido_item>();
            this.tb_tipo_cartao_estoque = new HashSet<tb_tipo_cartao_estoque>();
            this.tb_tipo_cartao_forma_pagamento = new HashSet<tb_tipo_cartao_forma_pagamento>();
            this.tb_tipo_cartao_valor = new HashSet<tb_tipo_cartao_valor>();
            this.tb_usuario_cartao = new HashSet<tb_usuario_cartao>();
            this.tb_usuario_revenda_comissao = new HashSet<tb_usuario_revenda_comissao>();
        }
    
        public int cd_tipo_cartao { get; set; }
        public int cd_operadora { get; set; }
        public string ds_tipo_cartao { get; set; }
        public string ds_detalhe_operacao { get; set; }
        public decimal vl_maximo_credito { get; set; }
        public decimal vl_minimo_credito { get; set; }
        public string ds_sigla_tipo_cartao { get; set; }
        public int cd_tipo_cartao_tecnologia { get; set; }
        public bool ic_tipo_cartao_inativo { get; set; }
        public bool ic_bloqueio_cartao { get; set; }
        public string ds_codigo_bloqueio { get; set; }
        public string ds_descricao_bloqueio { get; set; }
        public bool ic_primeira_via { get; set; }
        public decimal vl_emissao_primeira_via { get; set; }
        public bool ic_segunda_via { get; set; }
        public decimal vl_emissao_segunda_via { get; set; }
        public string ds_url_imagem_tipo_cartao { get; set; }
        public Nullable<bool> ic_tipo_cartao_estudante { get; set; }
        public Nullable<bool> ic_tipo_cartao_vt { get; set; }
        public Nullable<bool> ic_tipo_cartao_usuario { get; set; }
        public Nullable<decimal> vl_tarifa { get; set; }
        public bool ic_revalidacao_cartao { get; set; }
        public decimal vl_revalidacao_operadora { get; set; }
        public decimal vl_revalidacao_servico { get; set; }
        public Nullable<bool> ic_cartao_identificado { get; set; }
        public bool ic_valida_limite_recarga { get; set; }
        public string ds_tipo_produto_sobre { get; set; }
        public bool ic_cpf_cod_assinatura { get; set; }
        public bool ic_cartao_virtual { get; set; }
        public Nullable<bool> ic_pre_pedido_operadora { get; set; }
        public Nullable<bool> ic_cartao_fisico { get; set; }
        public Nullable<decimal> vl_taxa_entrega { get; set; }
        public Nullable<bool> ic_recarga_programada { get; set; }
        public Nullable<bool> ic_recarga_agendada { get; set; }
        public Nullable<bool> ic_possui_integracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_black_list> tb_black_list { get; set; }
        public virtual tb_operadora tb_operadora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_operadora_empresa_tipo_cartao> tb_operadora_empresa_tipo_cartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_parametro_cashback> tb_parametro_cashback { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_parametro_revenda_comissao> tb_parametro_revenda_comissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_item> tb_pedido_item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tipo_cartao_estoque> tb_tipo_cartao_estoque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tipo_cartao_forma_pagamento> tb_tipo_cartao_forma_pagamento { get; set; }
        public virtual tb_tipo_cartao_tecnologia tb_tipo_cartao_tecnologia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tipo_cartao_valor> tb_tipo_cartao_valor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cartao> tb_usuario_cartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_revenda_comissao> tb_usuario_revenda_comissao { get; set; }
    }
}
