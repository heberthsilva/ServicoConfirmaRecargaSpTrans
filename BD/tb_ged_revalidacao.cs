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
    
    public partial class tb_ged_revalidacao
    {
        public int cd_ged_revalidacao { get; set; }
        public long cd_pedido { get; set; }
        public byte[] ds_imagem_binary { get; set; }
        public Nullable<bool> ic_importada { get; set; }
        public string ds_caminho_imagem { get; set; }
        public byte[] ds_foto_binary { get; set; }
        public Nullable<bool> ic_importada_foto { get; set; }
        public string ds_caminho_foto { get; set; }
    
        public virtual tb_pedido tb_pedido { get; set; }
    }
}
