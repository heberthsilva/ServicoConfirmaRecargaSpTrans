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
    
    public partial class tb_transacao_programa_fidelidade
    {
        public long cd_transacao_programa_fidelidade { get; set; }
        public long cd_usuario { get; set; }
        public string tp_transacao { get; set; }
        public string ds_transacao { get; set; }
        public int vl_pontos { get; set; }
        public System.DateTime dt_transacao { get; set; }
        public bool ic_inativo { get; set; }
        public Nullable<System.DateTime> dt_transacao_expiracao { get; set; }
        public Nullable<bool> ic_processado { get; set; }
    
        public virtual tb_usuario tb_usuario { get; set; }
    }
}