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
    
    public partial class tb_duvida
    {
        public int cd_duvida { get; set; }
        public short cd_duvida_assunto { get; set; }
        public int nu_ordem { get; set; }
        public string ds_pergunta { get; set; }
        public string ds_resposta { get; set; }
        public System.DateTime dt_cadastro { get; set; }
        public bool ic_inativo { get; set; }
        public Nullable<int> nu_likes { get; set; }
        public Nullable<int> nu_deslikes { get; set; }
    
        public virtual tb_duvida_assunto tb_duvida_assunto { get; set; }
    }
}
