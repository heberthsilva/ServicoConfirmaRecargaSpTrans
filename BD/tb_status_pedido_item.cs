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
    
    public partial class tb_status_pedido_item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_status_pedido_item()
        {
            this.tb_log_pedido_item = new HashSet<tb_log_pedido_item>();
            this.tb_pedido_item = new HashSet<tb_pedido_item>();
            this.tb_tipo_pedido_item_fluxo_status = new HashSet<tb_tipo_pedido_item_fluxo_status>();
        }
    
        public short cd_status_pedido_item { get; set; }
        public string nm_descricao { get; set; }
        public string ds_css_icon { get; set; }
        public bool ic_status_pedido_inativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_pedido_item> tb_log_pedido_item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_item> tb_pedido_item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tipo_pedido_item_fluxo_status> tb_tipo_pedido_item_fluxo_status { get; set; }
    }
}
