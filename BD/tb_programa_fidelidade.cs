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
    
    public partial class tb_programa_fidelidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_programa_fidelidade()
        {
            this.tb_usuario = new HashSet<tb_usuario>();
        }
    
        public short cd_programa_fidelidade { get; set; }
        public string ds_programa_fidelidade { get; set; }
        public int vl_pontos_inicio { get; set; }
        public int vl_pontos_fim { get; set; }
        public string ds_cor_borda { get; set; }
        public string ds_cor_centro { get; set; }
        public System.DateTime dt_cadastro { get; set; }
        public bool ic_inativo { get; set; }
        public string ds_resumo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario> tb_usuario { get; set; }
    }
}
