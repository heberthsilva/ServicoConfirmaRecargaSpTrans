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
    
    public partial class tb_envio_email
    {
        public long cd_envio_email { get; set; }
        public string ds_assunto { get; set; }
        public int cd_tipo_email { get; set; }
        public Nullable<long> cd_usuario { get; set; }
        public string email_usuario { get; set; }
        public string ds_corpo_email { get; set; }
        public bool ic_envio { get; set; }
        public System.DateTime dt_criacao { get; set; }
        public Nullable<System.DateTime> dt_enviado { get; set; }
        public Nullable<long> cd_erro { get; set; }
    }
}
