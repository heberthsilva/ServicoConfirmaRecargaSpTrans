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
    
    public partial class tb_log_black_list
    {
        public long cd_log_black_list { get; set; }
        public short ic_tipo_log { get; set; }
        public string nu_cpf { get; set; }
        public string ds_email_usuario { get; set; }
        public Nullable<int> cd_tipo_cartao { get; set; }
        public string nu_cartao { get; set; }
        public string ds_motivo { get; set; }
        public System.DateTime dt_data_hora_log { get; set; }
        public int cd_usuario_adm { get; set; }
    
        public virtual tb_usuario_adm tb_usuario_adm { get; set; }
    }
}