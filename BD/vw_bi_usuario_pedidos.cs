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
    
    public partial class vw_bi_usuario_pedidos
    {
        public long cd_usuario { get; set; }
        public Nullable<long> cd_usuario_cartao { get; set; }
        public Nullable<int> cd_tipo_cartao { get; set; }
        public long cd_pedido { get; set; }
        public Nullable<long> cd_pedido_item { get; set; }
        public Nullable<decimal> vl_valor_recarga { get; set; }
        public Nullable<decimal> vl_taxa { get; set; }
        public Nullable<decimal> vl_desconto { get; set; }
        public Nullable<decimal> vl_entrega { get; set; }
        public Nullable<decimal> vl_total_pedido { get; set; }
        public short cd_forma_pagamento { get; set; }
        public string dt_datahora_pedido_operadora { get; set; }
        public string dt_quinzena { get; set; }
        public string dt_mes { get; set; }
        public Nullable<int> dt_ano { get; set; }
        public Nullable<int> cd_operadora { get; set; }
    }
}