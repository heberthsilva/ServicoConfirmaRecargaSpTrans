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
    
    public partial class tb_crm_motivo_relacionamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_crm_motivo_relacionamento()
        {
            this.tb_crm_relacionamento = new HashSet<tb_crm_relacionamento>();
        }
    
        public short cd_motivo_relacionamento { get; set; }
        public string ds_motivo { get; set; }
        public Nullable<bool> ic_motivo_relacionamento_inativo { get; set; }
        public string ds_motivo_pre_definido { get; set; }
        public Nullable<int> cd_setor { get; set; }
        public Nullable<int> ic_pedido { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_crm_relacionamento> tb_crm_relacionamento { get; set; }
    }
}
