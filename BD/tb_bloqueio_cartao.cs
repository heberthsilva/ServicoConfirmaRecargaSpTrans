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
    
    public partial class tb_bloqueio_cartao
    {
        public long cd_bloqueio_cartao { get; set; }
        public long cd_usuario_cartao { get; set; }
        public System.DateTime dt_datahora_bloqueio_cartao { get; set; }
        public string ds_chave_bloqueio_cartao_operadora { get; set; }
        public Nullable<System.DateTime> dt_datahora_bloqueio_cartao_operadora { get; set; }
    
        public virtual tb_usuario_cartao tb_usuario_cartao { get; set; }
    }
}