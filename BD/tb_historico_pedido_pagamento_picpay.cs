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
    
    public partial class tb_historico_pedido_pagamento_picpay
    {
        public long cd_historico_pedido_pagamento_picpay { get; set; }
        public Nullable<long> cd_pedido { get; set; }
        public Nullable<int> cd_status { get; set; }
        public Nullable<System.DateTime> dt_notificacao { get; set; }
        public string ds_authorizationId { get; set; }
    }
}
