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
    
    public partial class sp_rel_acerto_operadora_Result
    {
        public string dt_datahora_pedido { get; set; }
        public string nm_descricao_forma_pagamento { get; set; }
        public long cd_pedido_item { get; set; }
        public string nm_fantasia_operadora { get; set; }
        public string ds_tipo_cartao { get; set; }
        public string nu_cartao { get; set; }
        public Nullable<decimal> vl_valor_recarga { get; set; }
        public string ds_pedido_operadora { get; set; }
        public string dt_datahora_estocagem { get; set; }
        public Nullable<int> dt_semana { get; set; }
        public Nullable<int> dt_dia_semana { get; set; }
        public string dt_fechamento { get; set; }
        public string dt_previsao_pag { get; set; }
        public Nullable<int> cd_operadora { get; set; }
        public Nullable<decimal> vl_percentual_faturamento { get; set; }
        public Nullable<short> nu_qtd_dias_repasse { get; set; }
        public Nullable<decimal> vl_taxa { get; set; }
        public short tp_pedido_item { get; set; }
        public string nm_operadora_empresa { get; set; }
    }
}
