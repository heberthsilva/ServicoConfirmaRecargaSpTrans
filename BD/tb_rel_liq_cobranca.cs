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
    
    public partial class tb_rel_liq_cobranca
    {
        public long cd_rel_liq_cobranca { get; set; }
        public Nullable<long> cd_pedido { get; set; }
        public Nullable<long> cd_usuario { get; set; }
        public string nm_usuario { get; set; }
        public Nullable<System.DateTime> dt_vencimento { get; set; }
        public Nullable<System.DateTime> dt_data_pagamento { get; set; }
        public Nullable<decimal> vl_total_pedido { get; set; }
        public Nullable<decimal> vl_taxa { get; set; }
        public Nullable<decimal> vl_valor_pago { get; set; }
        public string ds_ocorrencia { get; set; }
        public string nu_nosso_numero { get; set; }
        public Nullable<bool> ic_processado { get; set; }
    
        public virtual tb_pedido tb_pedido { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
    }
}