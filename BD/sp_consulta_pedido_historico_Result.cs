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
    
    public partial class sp_consulta_pedido_historico_Result
    {
        public long cd_pedido { get; set; }
        public long cd_usuario { get; set; }
        public short cd_forma_pagamento { get; set; }
        public short cd_status_pedido { get; set; }
        public string nm_descricao { get; set; }
        public string ds_css_icon { get; set; }
        public System.DateTime dt_datahora_pedido { get; set; }
        public Nullable<System.DateTime> dt_data_pagamento { get; set; }
        public Nullable<decimal> vl_valor_pago { get; set; }
        public decimal vl_pedido { get; set; }
        public decimal vl_taxa { get; set; }
        public decimal vl_total_pedido { get; set; }
        public Nullable<decimal> vl_desconto { get; set; }
        public string ds_chave_transacao { get; set; }
        public Nullable<bool> ic_repetir_pedido { get; set; }
        public Nullable<decimal> vl_cashback { get; set; }
        public short cd_canal { get; set; }
        public bool ic_canal_inativo { get; set; }
        public bool ic_EMPRESA3mais { get; set; }
    }
}
