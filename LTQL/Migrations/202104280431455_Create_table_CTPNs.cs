namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_CTPNs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTPNs",
                c => new
                    {
                        STTPN = c.Int(nullable: false, identity: true),
                        MaPN = c.String(nullable: false, maxLength: 10),
                        TenPN = c.String(nullable: false, maxLength: 50),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        TenKH = c.String(nullable: false, maxLength: 50),
                        Soluong = c.Int(nullable: false),
                        Dongia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.STTPN);
            
            CreateTable(
                "dbo.CTPXs",
                c => new
                    {
                        STTPX = c.Int(nullable: false, identity: true),
                        MaPX = c.String(nullable: false, maxLength: 10),
                        TenPX = c.String(nullable: false, maxLength: 50),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        TenNCC = c.String(nullable: false, maxLength: 50),
                        Soluong = c.Int(nullable: false),
                        Dongia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.STTPX);
            
            CreateTable(
                "dbo.KHACHHANGs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenKH = c.String(nullable: false, maxLength: 50),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        SĐT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.KHHOHANGs",
                c => new
                    {
                        Makho = c.String(nullable: false, maxLength: 10, unicode: false),
                        Tenkho = c.String(nullable: false, maxLength: 50),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        Thukho = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Makho);
            
            CreateTable(
                "dbo.MATHANGs",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        Makho = c.String(nullable: false, maxLength: 10),
                        TRONGKHOs_STT = c.Int(),
                    })
                .PrimaryKey(t => t.MaMH)
                .ForeignKey("dbo.TRONGKHOs", t => t.TRONGKHOs_STT)
                .Index(t => t.TRONGKHOs_STT);
            
            CreateTable(
                "dbo.TRONGKHOs",
                c => new
                    {
                        STT = c.Int(nullable: false, identity: true),
                        Tenkho = c.String(nullable: false, maxLength: 50),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        Soluong = c.Int(nullable: false),
                        DVT = c.String(),
                        Dongia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.NHACUNGCAPs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenNCC = c.String(nullable: false, maxLength: 50),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        SDT = c.String(),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.PHIEUNHAPs",
                c => new
                    {
                        MaPN = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaMH = c.String(),
                        Ngaynhap = c.DateTime(nullable: false),
                        Nhanvien = c.String(),
                    })
                .PrimaryKey(t => t.MaPN);
            
            CreateTable(
                "dbo.PHIEUXUATs",
                c => new
                    {
                        MaPX = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaMH = c.String(),
                        Ngayxuat = c.DateTime(nullable: false),
                        Nhanvien = c.String(),
                    })
                .PrimaryKey(t => t.MaPX);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MATHANGs", "TRONGKHOs_STT", "dbo.TRONGKHOs");
            DropIndex("dbo.MATHANGs", new[] { "TRONGKHOs_STT" });
            DropTable("dbo.PHIEUXUATs");
            DropTable("dbo.PHIEUNHAPs");
            DropTable("dbo.NHACUNGCAPs");
            DropTable("dbo.TRONGKHOs");
            DropTable("dbo.MATHANGs");
            DropTable("dbo.KHHOHANGs");
            DropTable("dbo.KHACHHANGs");
            DropTable("dbo.CTPXs");
            DropTable("dbo.CTPNs");
        }
    }
}
