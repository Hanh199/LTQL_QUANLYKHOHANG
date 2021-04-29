using LTQL.Controllers;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHOHANG> KHOHANGs { get; set; }
        public virtual DbSet<TRONGKHO> TRONGKHOs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }
        public virtual DbSet<CTPN> CTPNs { get; set; }
        public virtual DbSet<CTPX> CTPXs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<THONGTIN> THONGTINs  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MATHANG>()
               .Property(e => e.MaMH)
              .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
               .Property(e => e.MaKH)
              .IsUnicode(false);

            modelBuilder.Entity<KHOHANG>()
               .Property(e => e.Makho)
              .IsUnicode(false);

            modelBuilder.Entity<TRONGKHO>()
               .Property(e => e.STT);

            modelBuilder.Entity<PHIEUNHAP>()
               .Property(e => e.MaPN)
              .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
               .Property(e => e.MaPX)
              .IsUnicode(false);

            modelBuilder.Entity<CTPN>()
               .Property(e => e.STTPN);

            modelBuilder.Entity<CTPX>()
              .Property(e => e.STTPX);

            modelBuilder.Entity<NHACUNGCAP>()
               .Property(e => e.MaNCC)
              .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<LTQL.Models.Articles> Articles { get; set; }
    }
}
