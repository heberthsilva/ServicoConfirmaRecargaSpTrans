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
    
    public partial class tb_status_entrega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_status_entrega()
        {
            this.tb_tarefa_entrega = new HashSet<tb_tarefa_entrega>();
        }
    
        public short cd_status_entrega { get; set; }
        public string ds_status_entrega { get; set; }
        public short nu_order_status_entrega { get; set; }
        public bool ic_intatico_entrega { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tarefa_entrega> tb_tarefa_entrega { get; set; }
    }
}
