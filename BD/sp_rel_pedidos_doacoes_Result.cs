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
    
    public partial class sp_rel_pedidos_doacoes_Result
    {
        public long cd_usuario { get; set; }
        public string nm_usuario { get; set; }
        public string nu_ddd_telefone { get; set; }
        public string nu_telefone { get; set; }
        public string ds_email_usuario { get; set; }
        public decimal vl_valor_recarga { get; set; }
        public string nm_descricao { get; set; }
        public string nm_descricao1 { get; set; }
        public long cd_pedido { get; set; }
        public string nu_cpf_usuario { get; set; }
        public string nu_cnpj_usuario { get; set; }
        public Nullable<System.DateTime> dt_data_pagamento { get; set; }
    }
}
