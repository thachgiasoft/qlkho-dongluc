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
    
    public partial class STO_VatTu
    {
        public STO_VatTu()
        {
            this.EXP_PhieuXuatCT = new HashSet<EXP_PhieuXuatCT>();
            this.IMP_PhieuNhapCT = new HashSet<IMP_PhieuNhapCT>();
            this.STO_KhoVatTuCT = new HashSet<STO_KhoVatTuCT>();
            this.STO_TonDauKyCT = new HashSet<STO_TonDauKyCT>();
        }
    
        public int ID_vat_tu { get; set; }
        public int ID_loai_vat_tu { get; set; }
        public string Ma_vat_tu { get; set; }
        public string Ten_vat_tu { get; set; }
        public Nullable<double> Don_vi { get; set; }
        public string Mo_ta { get; set; }
    
        public virtual ICollection<EXP_PhieuXuatCT> EXP_PhieuXuatCT { get; set; }
        public virtual ICollection<IMP_PhieuNhapCT> IMP_PhieuNhapCT { get; set; }
        public virtual ICollection<STO_KhoVatTuCT> STO_KhoVatTuCT { get; set; }
        public virtual ICollection<STO_TonDauKyCT> STO_TonDauKyCT { get; set; }
        public virtual STO_LoaiVatTu STO_LoaiVatTu { get; set; }
    }
}
