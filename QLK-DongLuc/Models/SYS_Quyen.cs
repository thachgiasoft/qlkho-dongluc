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
    
    public partial class SYS_Quyen
    {
        public SYS_Quyen()
        {
            this.SYS_VaiTroQuyen = new HashSet<SYS_VaiTroQuyen>();
        }
    
        public int ID_quyen { get; set; }
        public int ID_cha { get; set; }
        public string Ma_quyen { get; set; }
        public string Ten_quyen { get; set; }
        public string Loai_dieu_khien { get; set; }
        public Nullable<int> ID_goc { get; set; }
    
        public virtual ICollection<SYS_VaiTroQuyen> SYS_VaiTroQuyen { get; set; }
    }
}
