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
    
    public partial class tb_parametro
    {
        public short cd_parametro { get; set; }
        public int nu_conta_padrao_carrinho { get; set; }
        public int nu_conta_padrao_EMPRESA3lometros { get; set; }
        public string ds_servidor_wso { get; set; }
        public short qt_dias_processo_cashback { get; set; }
        public decimal vl_banco_transf { get; set; }
        public decimal vl_banco_ted { get; set; }
        public int nu_conta_padrao_cash_in { get; set; }
        public string ds_servidor_lomadee { get; set; }
        public string ds_token_lomadee { get; set; }
        public Nullable<int> id_source_lomadee { get; set; }
        public string ds_vs_api_ofertas { get; set; }
        public string ds_vs_api_cupom { get; set; }
        public int nu_conta_padrao_cashout_revenda { get; set; }
        public string ds_servidor_operadora_entrega { get; set; }
        public string ds_login_operadora_entrega { get; set; }
        public string ds_token_operadora_entrega { get; set; }
        public Nullable<int> nu_qtd_contas_limite { get; set; }
        public string ds_servidor_wso_pix { get; set; }
        public string ds_servidor_wso_pix_token { get; set; }
        public string ds_token_basic_pix { get; set; }
        public Nullable<bool> ic_ambiente_producao { get; set; }
        public Nullable<decimal> vl_fator_taxa_entrega { get; set; }
        public string ds_endereco_api_EMPRESA3 { get; set; }
        public Nullable<bool> ic_realiza_transacao_zero_mundipagg { get; set; }
    }
}
