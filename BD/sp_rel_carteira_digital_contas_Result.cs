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
    
    public partial class sp_rel_carteira_digital_contas_Result
    {
        public System.DateTime dt_cadastro { get; set; }
        public long cd_usuario { get; set; }
        public string nm_usuario { get; set; }
        public string status_conta { get; set; }
        public Nullable<long> id_usuario_banco { get; set; }
        public Nullable<long> id_conta { get; set; }
        public Nullable<System.DateTime> dt_inativo { get; set; }
        public Nullable<System.DateTime> dt_conta_bloqueada { get; set; }
    }
}
