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
    
    public partial class tb_log_alt_telefone
    {
        public long cd_log_alt_telefone { get; set; }
        public long cd_usuario { get; set; }
        public string nu_ddd_telefone_ant { get; set; }
        public string nu_telefone_ant { get; set; }
        public string nu_ddd_telefone_novo { get; set; }
        public string nu_telefone_novo { get; set; }
        public System.DateTime dt_registro { get; set; }
    
        public virtual tb_usuario tb_usuario { get; set; }
    }
}
