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
    
    public partial class tb_usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_usuario()
        {
            this.tb_avaliacao = new HashSet<tb_avaliacao>();
            this.tb_crm_relacionamento = new HashSet<tb_crm_relacionamento>();
            this.tb_cupom_usuario = new HashSet<tb_cupom_usuario>();
            this.tb_fila_notificacao = new HashSet<tb_fila_notificacao>();
            this.tb_formulario_resposta_usuario = new HashSet<tb_formulario_resposta_usuario>();
            this.tb_ged_pedido_cartao = new HashSet<tb_ged_pedido_cartao>();
            this.tb_ged_temporario = new HashSet<tb_ged_temporario>();
            this.tb_EMPRESA3lometros = new HashSet<tb_EMPRESA3lometros>();
            this.tb_log_alt_telefone = new HashSet<tb_log_alt_telefone>();
            this.tb_log_doacao = new HashSet<tb_log_doacao>();
            this.tb_log_email = new HashSet<tb_log_email>();
            this.tb_log_registro = new HashSet<tb_log_registro>();
            this.tb_log_sms = new HashSet<tb_log_sms>();
            this.tb_log_usuario_alteracao = new HashSet<tb_log_usuario_alteracao>();
            this.tb_log_usuario_cartao = new HashSet<tb_log_usuario_cartao>();
            this.tb_log_usuario_programa_fidelidade = new HashSet<tb_log_usuario_programa_fidelidade>();
            this.tb_log_usuario_revenda = new HashSet<tb_log_usuario_revenda>();
            this.tb_log_usuario_revenda_comissao = new HashSet<tb_log_usuario_revenda_comissao>();
            this.tb_log_usuario_revenda_limite = new HashSet<tb_log_usuario_revenda_limite>();
            this.tb_log_usuario_revenda_suspenso = new HashSet<tb_log_usuario_revenda_suspenso>();
            this.tb_notificacao = new HashSet<tb_notificacao>();
            this.tb_pedido = new HashSet<tb_pedido>();
            this.tb_pedido_atm = new HashSet<tb_pedido_atm>();
            this.tb_pedido_cash_in = new HashSet<tb_pedido_cash_in>();
            this.tb_pedido_revenda = new HashSet<tb_pedido_revenda>();
            this.tb_recarga_automatica = new HashSet<tb_recarga_automatica>();
            this.tb_recarga_programada = new HashSet<tb_recarga_programada>();
            this.tb_rel_liq_cobranca = new HashSet<tb_rel_liq_cobranca>();
            this.tb_transacao_conta_digital = new HashSet<tb_transacao_conta_digital>();
            this.tb_transacao_programa_fidelidade = new HashSet<tb_transacao_programa_fidelidade>();
            this.tb_usuario_banco_conta = new HashSet<tb_usuario_banco_conta>();
            this.tb_usuario_cartao_credito = new HashSet<tb_usuario_cartao_credito>();
            this.tb_usuario_cartao = new HashSet<tb_usuario_cartao>();
            this.tb_usuario_conta_corrente = new HashSet<tb_usuario_conta_corrente>();
            this.tb_usuario_cupom = new HashSet<tb_usuario_cupom>();
            this.tb_usuario_dependente = new HashSet<tb_usuario_dependente>();
            this.tb_usuario_endereco = new HashSet<tb_usuario_endereco>();
            this.tb_usuario_equipamento = new HashSet<tb_usuario_equipamento>();
            this.tb_usuario_favorito_linha = new HashSet<tb_usuario_favorito_linha>();
            this.tb_usuario_favorito_paradas = new HashSet<tb_usuario_favorito_paradas>();
            this.tb_usuario_revenda_comissao = new HashSet<tb_usuario_revenda_comissao>();
            this.tb_usuario_revenda_operadora = new HashSet<tb_usuario_revenda_operadora>();
            this.tb_usuario_revenda_pre_estocagem = new HashSet<tb_usuario_revenda_pre_estocagem>();
            this.tb_usuario_saldo = new HashSet<tb_usuario_saldo>();
            this.tb_usuario1 = new HashSet<tb_usuario>();
            this.tb_usuario11 = new HashSet<tb_usuario>();
            this.tb_usuario_termo_de_uso = new HashSet<tb_usuario_termo_de_uso>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_avaliacao> tb_avaliacao { get; set; }
        public virtual tb_canal tb_canal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_crm_relacionamento> tb_crm_relacionamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cupom_usuario> tb_cupom_usuario { get; set; }
        public virtual tb_estado_civil tb_estado_civil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_fila_notificacao> tb_fila_notificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_formulario_resposta_usuario> tb_formulario_resposta_usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ged_pedido_cartao> tb_ged_pedido_cartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ged_temporario> tb_ged_temporario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EMPRESA3lometros> tb_EMPRESA3lometros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_alt_telefone> tb_log_alt_telefone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_doacao> tb_log_doacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_email> tb_log_email { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_registro> tb_log_registro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_sms> tb_log_sms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_alteracao> tb_log_usuario_alteracao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_cartao> tb_log_usuario_cartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_programa_fidelidade> tb_log_usuario_programa_fidelidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_revenda> tb_log_usuario_revenda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_revenda_comissao> tb_log_usuario_revenda_comissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_revenda_limite> tb_log_usuario_revenda_limite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_usuario_revenda_suspenso> tb_log_usuario_revenda_suspenso { get; set; }
        public virtual tb_nacionalidade tb_nacionalidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_notificacao> tb_notificacao { get; set; }
        public virtual tb_orgao_emissor tb_orgao_emissor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido> tb_pedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_atm> tb_pedido_atm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_cash_in> tb_pedido_cash_in { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_revenda> tb_pedido_revenda { get; set; }
        public virtual tb_programa_fidelidade tb_programa_fidelidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_recarga_automatica> tb_recarga_automatica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_recarga_programada> tb_recarga_programada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_rel_liq_cobranca> tb_rel_liq_cobranca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_transacao_conta_digital> tb_transacao_conta_digital { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_transacao_programa_fidelidade> tb_transacao_programa_fidelidade { get; set; }
        public virtual tb_uf tb_uf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_banco_conta> tb_usuario_banco_conta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cartao_credito> tb_usuario_cartao_credito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cartao> tb_usuario_cartao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_conta_corrente> tb_usuario_conta_corrente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_cupom> tb_usuario_cupom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_dependente> tb_usuario_dependente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_endereco> tb_usuario_endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_equipamento> tb_usuario_equipamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_favorito_linha> tb_usuario_favorito_linha { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_favorito_paradas> tb_usuario_favorito_paradas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_revenda_comissao> tb_usuario_revenda_comissao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_revenda_operadora> tb_usuario_revenda_operadora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_revenda_pre_estocagem> tb_usuario_revenda_pre_estocagem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_saldo> tb_usuario_saldo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario> tb_usuario1 { get; set; }
        public virtual tb_usuario tb_usuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario> tb_usuario11 { get; set; }
        public virtual tb_usuario tb_usuario3 { get; set; }
        public virtual tb_usuario tb_usuario12 { get; set; }
        public virtual tb_usuario tb_usuario4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_termo_de_uso> tb_usuario_termo_de_uso { get; set; }
    }
}