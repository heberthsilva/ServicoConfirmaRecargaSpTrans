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
    
    public partial class tb_log_sbe
    {
        public long cd_log_sbe { get; set; }
        public Nullable<long> cd_pedido { get; set; }
        public Nullable<long> cd_pedido_item { get; set; }
        public Nullable<System.DateTime> dt_pagamento { get; set; }
        public string ped_sbe { get; set; }
        public Nullable<System.DateTime> data_hora_estocagem { get; set; }
        public Nullable<System.DateTime> data_hora_carregado { get; set; }
    }
}
