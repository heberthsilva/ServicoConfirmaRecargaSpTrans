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
    
    public partial class sp_relatorio_relacionamento_Result
    {
        public string ds_perfil { get; set; }
        public Nullable<System.DateTime> dt_inicio_relacionamento { get; set; }
        public string origen { get; set; }
        public string nm_usuario_adm { get; set; }
        public string ds_motivo { get; set; }
        public string situacao { get; set; }
        public Nullable<int> cd_num_pedido { get; set; }
        public Nullable<System.DateTime> dt_datahora_pedido { get; set; }
        public long cd_usuario { get; set; }
        public string nm_usuario { get; set; }
        public string ds_email_usuario { get; set; }
        public string nu_cnpj_usuario { get; set; }
        public string nu_cpf_usuario { get; set; }
        public string cd_protocolo { get; set; }
        public Nullable<System.DateTime> dt_fim_relacionamento { get; set; }
        public string Arquivo { get; set; }
        public string ds_arquivo_binary { get; set; }
    }
}
