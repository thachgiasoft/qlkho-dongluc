//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKho_DongLuc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_NhaCungCap
    {
        public CAT_NhaCungCap()
        {
            this.IMP_PhieuNhap = new HashSet<IMP_PhieuNhap>();
        }
    
        public int ID_nha_cung_cap { get; set; }
        public string Ten_nha_cung_cap { get; set; }
        public string Nguoi_dai_dien { get; set; }
        public string Dien_thoai { get; set; }
        public string Email { get; set; }
        public string So_tai_khoan { get; set; }
    
        public virtual ICollection<IMP_PhieuNhap> IMP_PhieuNhap { get; set; }
    }
}
