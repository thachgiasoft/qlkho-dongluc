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
    
    public partial class IMP_LoaiNhap
    {
        public IMP_LoaiNhap()
        {
            this.IMP_PhieuNhap = new HashSet<IMP_PhieuNhap>();
        }
    
        public int ID_loai_nhap { get; set; }
        public string Ten_loai_nhap { get; set; }
        public string Ghi_chu { get; set; }
    
        public virtual ICollection<IMP_PhieuNhap> IMP_PhieuNhap { get; set; }
    }
}
