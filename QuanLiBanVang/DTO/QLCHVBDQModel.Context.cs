﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBQLCuaHangVangBacDaQuyEntities : DbContext
    {
        public DBQLCuaHangVangBacDaQuyEntities()
            : base("name=DBQLCuaHangVangBacDaQuyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAOCAOTHUCHI> BAOCAOTHUCHIs { get; set; }
        public virtual DbSet<BAOCAOTONKHO> BAOCAOTONKHOes { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CTPBH> CTPBHs { get; set; }
        public virtual DbSet<CTPDV> CTPDVs { get; set; }
        public virtual DbSet<CTPMH> CTPMHs { get; set; }
        public virtual DbSet<CTPNH> CTPNHs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HINHTHUCGIACONG> HINHTHUCGIACONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNGs { get; set; }
        public virtual DbSet<PHIEUBANHANG> PHIEUBANHANGs { get; set; }
        public virtual DbSet<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
        public virtual DbSet<PHIEUMUAHANG> PHIEUMUAHANGs { get; set; }
        public virtual DbSet<PHIEUNHAPHANG> PHIEUNHAPHANGs { get; set; }
        public virtual DbSet<PHIEUTHUTIENNO> PHIEUTHUTIENNOes { get; set; }
        public virtual DbSet<QUYENHAN> QUYENHANs { get; set; }
        public virtual DbSet<THO> THOes { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<Baocao> Baocaos { get; set; }
        public virtual DbSet<CTGIACONGSP> CTGIACONGSPs { get; set; }
        public virtual DbSet<PHIEUGIACONG> PHIEUGIACONGs { get; set; }
        public virtual DbSet<CTPGC> CTPGCs { get; set; }
        public virtual DbSet<PHIEUCHI> PHIEUCHIs { get; set; }
    
        public virtual int DEL_IN_CTPN(Nullable<int> masp, Nullable<int> sophieunhap)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var sophieunhapParameter = sophieunhap.HasValue ?
                new ObjectParameter("sophieunhap", sophieunhap) :
                new ObjectParameter("sophieunhap", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DEL_IN_CTPN", maspParameter, sophieunhapParameter);
        }
    
        public virtual int CalculateCostInDate(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalculateCostInDate", dateParameter);
        }
    
        public virtual int CalculateIncomeInDate(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalculateIncomeInDate", dateParameter);
        }
    
        public virtual ObjectResult<CalculateNumberOfIncomeBill_Result> CalculateNumberOfIncomeBill(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CalculateNumberOfIncomeBill_Result>("CalculateNumberOfIncomeBill", dateParameter);
        }
    
        public virtual ObjectResult<CalculateStoreStatus_Result> CalculateStoreStatus()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CalculateStoreStatus_Result>("CalculateStoreStatus");
        }
    }
}
