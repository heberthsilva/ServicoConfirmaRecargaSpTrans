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
    
    public partial class tb_parametro_cashback
    {
        public int cd_parametro_cashback { get; set; }
        public int cd_tipo_cartao { get; set; }
        public short cd_forma_pagamento { get; set; }
        public decimal tx_cashback { get; set; }
        public bool ic_inativo { get; set; }
    
        public virtual tb_forma_pagamento tb_forma_pagamento { get; set; }
        public virtual tb_tipo_cartao tb_tipo_cartao { get; set; }
    }
}
