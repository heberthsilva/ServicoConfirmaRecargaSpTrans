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
    
    public partial class tb_terminal
    {
        public int cd_terminal { get; set; }
        public int cd_operadora { get; set; }
        public long nu_serie_terminal { get; set; }
        public string ds_imei_modem { get; set; }
        public string ds_serie_chip { get; set; }
        public string ds_modelo_chip { get; set; }
        public string ds_tel_chip { get; set; }
        public System.DateTime dt_comunicacao_terminal { get; set; }
        public string ds_codigo_veiculo { get; set; }
        public Nullable<int> cd_operadora_empresa { get; set; }
        public bool ic_inativo { get; set; }
        public Nullable<System.DateTime> dt_cadastro { get; set; }
        public bool ic_manutencao { get; set; }
    
        public virtual tb_operadora tb_operadora { get; set; }
        public virtual tb_operadora_empresa tb_operadora_empresa { get; set; }
    }
}
