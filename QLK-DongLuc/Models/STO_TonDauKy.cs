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
    
    public partial class STO_TonDauKy
    {
        public int ID_vat_tu { get; set; }
        public System.DateTime Ky { get; set; }
        public double Ton_dau_ky { get; set; }
        public int ID_kho { get; set; }
    
        public virtual STO_KhoVatTu STO_KhoVatTu { get; set; }
        public virtual STO_VatTu STO_VatTu { get; set; }
    }
}
