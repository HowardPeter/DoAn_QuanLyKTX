//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_QuanLyKTX
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOANQL
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> MaQL { get; set; }
    
        public virtual QUANLY QUANLY { get; set; }
    }
}
