﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyKyTucXaEntities3 : DbContext
    {
        public QuanLyKyTucXaEntities3()
            : base("name=QuanLyKyTucXaEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DONDANGKY> DONDANGKies { get; set; }
        public virtual DbSet<NGUOITHAN> NGUOITHANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIKTX> PHIKTXes { get; set; }
        public virtual DbSet<PHONGKYTUC> PHONGKYTUCs { get; set; }
        public virtual DbSet<QUANLY> QUANLies { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOANQL> TAIKHOANQLs { get; set; }
        public virtual DbSet<THOIGIANTHAM> THOIGIANTHAMs { get; set; }
        public virtual DbSet<TRANGTHIETBI> TRANGTHIETBIs { get; set; }
    }
}
