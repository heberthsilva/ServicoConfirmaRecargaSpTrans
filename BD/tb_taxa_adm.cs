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
    
    public partial class tb_taxa_adm
    {
        public int cd_taxa_adm { get; set; }
        public int cd_operadora { get; set; }
        public short cd_forma_pagamento { get; set; }
        public decimal nu_range_qtd_inicio { get; set; }
        public decimal nu_range_qtd_fim { get; set; }
        public decimal vl_taxa_pedido { get; set; }
        public decimal tx_item_credito { get; set; }
        public string ic_unidade_taxa_item_credito { get; set; }
        public string ic_tipo_range { get; set; }
    
        public virtual tb_forma_pagamento tb_forma_pagamento { get; set; }
        public virtual tb_operadora tb_operadora { get; set; }
    }
}