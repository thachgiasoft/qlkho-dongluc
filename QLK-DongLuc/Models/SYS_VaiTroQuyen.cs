//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLK_DongLuc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_VaiTroQuyen
    {
        public int ID_vai_tro { get; set; }
        public int ID_quyen { get; set; }
        public int ID_thuoc_tinh { get; set; }
        public bool Gia_tri { get; set; }
    
        public virtual SYS_Quyen SYS_Quyen { get; set; }
        public virtual SYS_ThuocTinh SYS_ThuocTinh { get; set; }
        public virtual SYS_VaiTro SYS_VaiTro { get; set; }
    }
}
