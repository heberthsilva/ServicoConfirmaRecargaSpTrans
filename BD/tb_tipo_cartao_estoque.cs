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
    
    public partial class tb_tipo_cartao_estoque
    {
        public long cd_tipo_cartao_estoque { get; set; }
        public int cd_tipo_cartao { get; set; }
        public string nu_cartao_estoque { get; set; }
        public Nullable<System.DateTime> dt_cartao_associado_estoque { get; set; }
        public Nullable<long> cd_usuario_cartao_antigo { get; set; }
    
        public virtual tb_tipo_cartao tb_tipo_cartao { get; set; }
        public virtual tb_usuario_cartao tb_usuario_cartao { get; set; }
    }
}