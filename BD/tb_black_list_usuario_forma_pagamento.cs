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
    
    public partial class tb_black_list_usuario_forma_pagamento
    {
        public int cd_black_list_usuario_forma_pagamento { get; set; }
        public int cd_black_list { get; set; }
        public string nu_cpf_usuario { get; set; }
        public short cd_forma_pagamento { get; set; }
    
        public virtual tb_black_list tb_black_list { get; set; }
        public virtual tb_forma_pagamento tb_forma_pagamento { get; set; }
    }
}
