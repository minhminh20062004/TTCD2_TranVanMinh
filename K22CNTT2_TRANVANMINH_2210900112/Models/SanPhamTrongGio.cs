//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K22CNTT2_TRANVANMINH_2210900112.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPhamTrongGio
    {
        public int MaSanPhamTrongGio { get; set; }
        public Nullable<int> MaGioHang { get; set; }
        public Nullable<int> MaSach { get; set; }
        public int SoLuong { get; set; }
    
        public virtual GioHang GioHang { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
