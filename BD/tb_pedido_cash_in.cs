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
    
    public partial class tb_pedido_cash_in
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_pedido_cash_in()
        {
            this.tb_ged_pedido_cash_in = new HashSet<tb_ged_pedido_cash_in>();
        }
    
        public long cd_pedido_cash_in { get; set; }
        public long cd_usuario { get; set; }
        public string nu_pedido_fast_cash_in { get; set; }
        public System.DateTime dt_pedido_cash_in { get; set; }
        public short cd_forma_pagamento { get; set; }
        public short cd_status_pedido_cash_in { get; set; }
        public decimal vl_total_cash_in { get; set; }
        public Nullable<short> id_banco_origem { get; set; }
        public string nu_agencia_origem { get; set; }
        public string nu_conta_origem { get; set; }
        public Nullable<short> id_banco_fast_cash { get; set; }
        public string ds_banco_fast_cash { get; set; }
        public string nu_agencia_fast_cash { get; set; }
        public string nu_conta_fast_cash { get; set; }
        public string ds_favorecido_fast_cash { get; set; }
        public string nu_cnpj_favorecido_fast_cash { get; set; }
        public Nullable<decimal> vl_total_pago_cash_in { get; set; }
        public Nullable<System.DateTime> dt_pagamento_cash_in { get; set; }
        public string ds_chave_transacao_cash_in { get; set; }
        public Nullable<bool> ic_processamento_banco_cash_in { get; set; }
        public Nullable<System.DateTime> dt_processamento_banco_cash_in { get; set; }
        public string ds_chave_processamento_banco_cash_in { get; set; }
        public long cd_usuario_banco_conta { get; set; }
        public Nullable<bool> ic_pagamento_lote { get; set; }
        public Nullable<System.DateTime> dt_pagamento_lote { get; set; }
        public string ds_num_pagamento_lote { get; set; }
        public Nullable<decimal> vl_taxa_transacao_lote { get; set; }
        public Nullable<decimal> vl_liquido_transacao_lote { get; set; }
    
        public virtual tb_forma_pagamento tb_forma_pagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ged_pedido_cash_in> tb_ged_pedido_cash_in { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
        public virtual tb_usuario_banco_conta tb_usuario_banco_conta { get; set; }
    }
}
