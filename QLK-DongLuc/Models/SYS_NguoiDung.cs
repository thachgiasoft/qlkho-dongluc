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
    
    public partial class SYS_NguoiDung
    {
        public SYS_NguoiDung()
        {
            this.CAT_KhachHang = new HashSet<CAT_KhachHang>();
            this.EXP_PhieuXuat = new HashSet<EXP_PhieuXuat>();
            this.IMP_PhieuNhap = new HashSet<IMP_PhieuNhap>();
            this.SYS_SuKienNguoiDung = new HashSet<SYS_SuKienNguoiDung>();
            this.SYS_VaiTro = new HashSet<SYS_VaiTro>();
        }
    
        public int ID_nguoi_dung { get; set; }
        public Nullable<int> ID_nhan_vien { get; set; }
        public string Tai_khoan { get; set; }
        public string Mat_khau { get; set; }
        public string Ten_day_du { get; set; }
        public int ID_trang_thai { get; set; }
        public Nullable<System.DateTime> Lan_dang_nhap_cuoi { get; set; }
        public Nullable<System.TimeSpan> Thoi_gian_cho { get; set; }
        public string May_tram { get; set; }
    
        public virtual ICollection<CAT_KhachHang> CAT_KhachHang { get; set; }
        public virtual CAT_NhanVien CAT_NhanVien { get; set; }
        public virtual ICollection<EXP_PhieuXuat> EXP_PhieuXuat { get; set; }
        public virtual ICollection<IMP_PhieuNhap> IMP_PhieuNhap { get; set; }
        public virtual SYS_TrangThaiNguoiDung SYS_TrangThaiNguoiDung { get; set; }
        public virtual ICollection<SYS_SuKienNguoiDung> SYS_SuKienNguoiDung { get; set; }
        public virtual ICollection<SYS_VaiTro> SYS_VaiTro { get; set; }
    }
}
