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
    
    public partial class tb_fila_notificacao
    {
        public long cd_fila_notificacao { get; set; }
        public long cd_usuario { get; set; }
        public string ds_titulo { get; set; }
        public string ds_mensagem { get; set; }
        public Nullable<short> cd_tipo_notificacao { get; set; }
        public string ds_link { get; set; }
    
        public virtual tb_tipo_notificacao tb_tipo_notificacao { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
    }
}
