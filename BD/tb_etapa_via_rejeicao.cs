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
    
    public partial class tb_etapa_via_rejeicao
    {
        public int cd_etapa_via_rejeicao { get; set; }
        public Nullable<int> cd_etapa_via { get; set; }
        public Nullable<long> cd_requisicao_via { get; set; }
        public Nullable<System.DateTime> dt_rejeicao { get; set; }
        public string ds_motivo_rejeicao { get; set; }
        public Nullable<bool> ic_corrigida { get; set; }
        public Nullable<System.DateTime> dt_correcao { get; set; }
        public Nullable<int> cd_usuario_adm { get; set; }
        public Nullable<bool> ic_excluida { get; set; }
        public Nullable<int> cd_usuario_exclusão { get; set; }
        public Nullable<System.DateTime> dt_exclusao { get; set; }
    }
}
