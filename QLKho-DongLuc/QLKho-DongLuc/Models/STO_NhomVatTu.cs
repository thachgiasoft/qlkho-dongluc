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
    
    public partial class STO_NhomVatTu
    {
        public STO_NhomVatTu()
        {
            this.STO_LoaiVatTu = new HashSet<STO_LoaiVatTu>();
        }
    
        public int ID_nhom_vat_tu { get; set; }
        public string Ten_nhom_vat_tu { get; set; }
        public string Ghi_chu { get; set; }
    
        public virtual ICollection<STO_LoaiVatTu> STO_LoaiVatTu { get; set; }
    }
}
