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
    
    public partial class tb_gateway_fastcash
    {
        public short cd_gateway_fastcash { get; set; }
        public short cd_gateway { get; set; }
        public int nu_pid { get; set; }
        public int nu_prodid { get; set; }
        public string nu_tid { get; set; }
        public bool ic_cash_in { get; set; }
    
        public virtual tb_gateway tb_gateway { get; set; }
    }
}
