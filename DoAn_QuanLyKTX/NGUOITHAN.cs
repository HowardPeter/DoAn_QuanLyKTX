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
    
    public partial class NGUOITHAN
    {
        public string TenNT { get; set; }
        public int MaSV { get; set; }
        public string GioiTinh { get; set; }
        public string QuanHe { get; set; }
        public string SoDT { get; set; }
    
        public virtual THOIGIANTHAM THOIGIANTHAM { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}