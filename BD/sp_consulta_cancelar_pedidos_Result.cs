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
    
    public partial class sp_consulta_cancelar_pedidos_Result
    {
        public long cd_pedido { get; set; }
        public string nu_cartao { get; set; }
        public string ds_servidor_conexao { get; set; }
        public Nullable<int> nu_codigo_revenda_operadora { get; set; }
        public long cd_pedido_item { get; set; }
        public decimal vl_valor_recarga { get; set; }
        public string ds_usuario_auth { get; set; }
        public string ds_senha_auth { get; set; }
        public Nullable<int> cd_operadora_versao_api { get; set; }
        public string ds_token_CitSoa { get; set; }
        public string ds_token_operadora { get; set; }
        public short tp_pedido_item { get; set; }
        public Nullable<bool> ic_pre_pedido_operadora { get; set; }
        public string ds_num_pre_pedido_operadora { get; set; }
    }
}
