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
    
    public partial class sp_searchReversal_Result
    {
        public int cd_estorno_pedido { get; set; }
        public long cd_pedido { get; set; }
        public long cd_usuario { get; set; }
        public string nm_usuario { get; set; }
        public decimal vl_total_pedido { get; set; }
        public Nullable<decimal> vl_valor_pago { get; set; }
        public Nullable<decimal> vl_estorno { get; set; }
        public System.DateTime dt_solicitacao_inicio { get; set; }
        public string nm_usuario_adm { get; set; }
        public Nullable<System.DateTime> dt_solicitacao_fim { get; set; }
        public string nm_usuario_adm1 { get; set; }
        public string ds_chave_transacao { get; set; }
        public string nm_descricao { get; set; }
        public int cd_estorno_pedido_item { get; set; }
        public string nm_fantasia_operadora { get; set; }
        public string ds_tipo_cartao { get; set; }
        public string nu_cartao { get; set; }
        public decimal vl_valor_recarga { get; set; }
        public string ds_pedido_operadora { get; set; }
        public Nullable<System.DateTime> dt_datahora_pedido_operadora { get; set; }
        public Nullable<int> nu_carga_operadora { get; set; }
        public string ds_motivo_estorno { get; set; }
    }
}
