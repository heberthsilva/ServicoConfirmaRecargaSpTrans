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
    
    public partial class tb_log_pedido
    {
        public long cd_log_pedido { get; set; }
        public long cd_pedido { get; set; }
        public short cd_status_pedido { get; set; }
        public Nullable<System.DateTime> dt_log { get; set; }
    
        public virtual tb_status_pedido tb_status_pedido { get; set; }
    }
}