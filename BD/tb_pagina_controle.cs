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
    
    public partial class tb_pagina_controle
    {
        public int cd_pagina_controle { get; set; }
        public Nullable<int> cd_pagina { get; set; }
        public Nullable<int> cd_controle { get; set; }
        public Nullable<int> nu_ordem { get; set; }
    
        public virtual tb_controle tb_controle { get; set; }
        public virtual tb_pagina tb_pagina { get; set; }
    }
}
