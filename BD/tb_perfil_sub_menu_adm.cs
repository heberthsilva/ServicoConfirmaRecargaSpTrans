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
    
    public partial class tb_perfil_sub_menu_adm
    {
        public short cd_perfil_sub_menu_adm { get; set; }
        public short cd_perfil { get; set; }
        public int cd_sub_menu_adm { get; set; }
    
        public virtual tb_perfil tb_perfil { get; set; }
        public virtual tb_sub_menu_adm tb_sub_menu_adm { get; set; }
    }
}
