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
    
    public partial class sp_detalhes_cliente_Result
    {
        public long cd_usuario { get; set; }
        public Nullable<long> cd_usuario_pai { get; set; }
        public string nu_cnpj_usuario { get; set; }
        public string nu_cpf_usuario { get; set; }
        public string nm_usuario { get; set; }
        public string nm_fantasia { get; set; }
        public Nullable<System.DateTime> dt_nascimento_usuario { get; set; }
        public string nm_sexo_usuario { get; set; }
        public string nu_ddd_telefone { get; set; }
        public string nu_telefone { get; set; }
        public string ds_email_usuario { get; set; }
        public string ds_senha_usuario { get; set; }
        public System.DateTime dt_cadastro_usuario { get; set; }
        public bool ic_usuario_inativo { get; set; }
        public string ds_token_usuario { get; set; }
        public bool ic_usuario_autenticado { get; set; }
        public Nullable<bool> ic_exp_erp { get; set; }
        public Nullable<System.DateTime> dt_exp_erp { get; set; }
        public Nullable<bool> ic_notificacao { get; set; }
        public string ds_usuario_token_push { get; set; }
        public Nullable<short> cd_canal { get; set; }
        public Nullable<short> cd_programa_fidelidade { get; set; }
        public Nullable<System.DateTime> dt_adesao_programa_fidelidade { get; set; }
        public string ds_codigo_promocional { get; set; }
        public Nullable<bool> ic_credito_confianca { get; set; }
        public Nullable<bool> ic_leitura_programa_fidelidade { get; set; }
        public string nm_apelido { get; set; }
        public string nm_mae { get; set; }
        public string nu_rg { get; set; }
        public Nullable<short> cd_orgao_emissor { get; set; }
        public Nullable<short> cd_uf_orgao_emissor { get; set; }
        public Nullable<System.DateTime> dt_emissao_rg { get; set; }
        public Nullable<short> cd_estado_civil { get; set; }
        public Nullable<short> cd_nacionalidade { get; set; }
        public Nullable<bool> ic_pep { get; set; }
        public Nullable<System.DateTime> dt_inicio_pep { get; set; }
        public bool ic_revenda { get; set; }
        public bool ic_autorizado_revenda { get; set; }
        public Nullable<short> ic_tipo_revenda { get; set; }
        public decimal vl_limite_revenda { get; set; }
        public short qtd_dias_acerto_revenda { get; set; }
        public bool ic_revenda_suspenso { get; set; }
        public Nullable<System.DateTime> dt_revenda_suspenso { get; set; }
        public short nu_qtd_equipamentos { get; set; }
        public Nullable<int> cd_natureza_juridica { get; set; }
        public Nullable<System.DateTime> dt_pj_abertura { get; set; }
        public string nu_pj_cnae { get; set; }
        public Nullable<decimal> vl_pj_receita_anual { get; set; }
        public Nullable<bool> ic_revenda_especial { get; set; }
        public Nullable<short> nu_qtd_alt_telefone { get; set; }
        public bool ic_email_autenticado { get; set; }
        public Nullable<System.DateTime> dt_email_autenticado { get; set; }
        public bool ic_telefone_autenticado { get; set; }
        public Nullable<System.DateTime> dt_telefone_autenticado { get; set; }
        public string ds_id_cashdeal { get; set; }
        public Nullable<System.DateTime> dt_ultimo_login { get; set; }
        public decimal cd_relacionamento { get; set; }
        public long cd_usuario1 { get; set; }
        public Nullable<System.DateTime> dt_inicio_relacionamento { get; set; }
        public Nullable<System.DateTime> dt_fim_relacionamento { get; set; }
        public string ds_nota { get; set; }
        public short cd_motivo_relacionamento { get; set; }
        public Nullable<short> cd_situacao_relacionamento { get; set; }
        public Nullable<short> cd_tipo_relacionamento { get; set; }
        public Nullable<int> cd_usuario_adm { get; set; }
        public Nullable<short> nu_prioridade { get; set; }
        public string cd_protocolo { get; set; }
        public string ds_protocolo_externo { get; set; }
        public Nullable<int> cd_num_pedido { get; set; }
        public Nullable<int> cd_tipo { get; set; }
        public string nu_pedido_cash_in { get; set; }
    }
}
