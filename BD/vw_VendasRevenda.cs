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
    
    public partial class vw_VendasRevenda
    {
        public long cd_usuario { get; set; }
        public Nullable<System.DateTime> dt_data_venda { get; set; }
        public Nullable<System.DateTime> dt_data_venda2 { get; set; }
        public string nm_fantasia_operadora { get; set; }
        public string ds_caminho_logo { get; set; }
        public string ds_tipo_cartao { get; set; }
        public long cd_pedido_item { get; set; }
        public decimal vl_valor_recarga { get; set; }
        public decimal vl_comissao { get; set; }
    }
}
