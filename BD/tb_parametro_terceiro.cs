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
    
    public partial class tb_parametro_terceiro
    {
        public int cd_parametro_terceiro { get; set; }
        public string ds_nome_terceiro { get; set; }
        public string ds_link_terceiro { get; set; }
        public string ds_link_autenticacao_terceiro { get; set; }
        public string ds_token_autenticacao_terceiro { get; set; }
        public string ds_token_terceiro { get; set; }
        public string ds_usuario_terceiro { get; set; }
        public string ds_senha_terceiro { get; set; }
        public Nullable<System.DateTime> dt_expiracao_token { get; set; }
    }
}
