namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.KHHOHANGs", newName: "KHOHANGs");
            AddColumn("dbo.KHACHHANGs", "CTPXs_STTPX", c => c.Int());
            AddColumn("dbo.KHOHANGs", "TRONGKHOs_STT", c => c.Int());
            AddColumn("dbo.MATHANGs", "CTPNs_STTPN", c => c.Int());
            AddColumn("dbo.MATHANGs", "CTPXs_STTPX", c => c.Int());
            AddColumn("dbo.NHACUNGCAPs", "CTPNs_STTPN", c => c.Int());
            AddColumn("dbo.NHACUNGCAPs", "CTPXs_STTPX", c => c.Int());
            AddColumn("dbo.PHIEUNHAPs", "CTPNs_STTPN", c => c.Int());
            AddColumn("dbo.PHIEUXUATs", "CTPXs_STTPX", c => c.Int());
            CreateIndex("dbo.MATHANGs", "CTPNs_STTPN");
            CreateIndex("dbo.MATHANGs", "CTPXs_STTPX");
            CreateIndex("dbo.KHACHHANGs", "CTPXs_STTPX");
            CreateIndex("dbo.NHACUNGCAPs", "CTPNs_STTPN");
            CreateIndex("dbo.NHACUNGCAPs", "CTPXs_STTPX");
            CreateIndex("dbo.PHIEUXUATs", "CTPXs_STTPX");
            CreateIndex("dbo.KHOHANGs", "TRONGKHOs_STT");
            CreateIndex("dbo.PHIEUNHAPs", "CTPNs_STTPN");
            AddForeignKey("dbo.MATHANGs", "CTPNs_STTPN", "dbo.CTPNs", "STTPN");
            AddForeignKey("dbo.KHACHHANGs", "CTPXs_STTPX", "dbo.CTPXs", "STTPX");
            AddForeignKey("dbo.MATHANGs", "CTPXs_STTPX", "dbo.CTPXs", "STTPX");
            AddForeignKey("dbo.NHACUNGCAPs", "CTPNs_STTPN", "dbo.CTPNs", "STTPN");
            AddForeignKey("dbo.NHACUNGCAPs", "CTPXs_STTPX", "dbo.CTPXs", "STTPX");
            AddForeignKey("dbo.PHIEUXUATs", "CTPXs_STTPX", "dbo.CTPXs", "STTPX");
            AddForeignKey("dbo.KHOHANGs", "TRONGKHOs_STT", "dbo.TRONGKHOs", "STT");
            AddForeignKey("dbo.PHIEUNHAPs", "CTPNs_STTPN", "dbo.CTPNs", "STTPN");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PHIEUNHAPs", "CTPNs_STTPN", "dbo.CTPNs");
            DropForeignKey("dbo.KHOHANGs", "TRONGKHOs_STT", "dbo.TRONGKHOs");
            DropForeignKey("dbo.PHIEUXUATs", "CTPXs_STTPX", "dbo.CTPXs");
            DropForeignKey("dbo.NHACUNGCAPs", "CTPXs_STTPX", "dbo.CTPXs");
            DropForeignKey("dbo.NHACUNGCAPs", "CTPNs_STTPN", "dbo.CTPNs");
            DropForeignKey("dbo.MATHANGs", "CTPXs_STTPX", "dbo.CTPXs");
            DropForeignKey("dbo.KHACHHANGs", "CTPXs_STTPX", "dbo.CTPXs");
            DropForeignKey("dbo.MATHANGs", "CTPNs_STTPN", "dbo.CTPNs");
            DropIndex("dbo.PHIEUNHAPs", new[] { "CTPNs_STTPN" });
            DropIndex("dbo.KHOHANGs", new[] { "TRONGKHOs_STT" });
            DropIndex("dbo.PHIEUXUATs", new[] { "CTPXs_STTPX" });
            DropIndex("dbo.NHACUNGCAPs", new[] { "CTPXs_STTPX" });
            DropIndex("dbo.NHACUNGCAPs", new[] { "CTPNs_STTPN" });
            DropIndex("dbo.KHACHHANGs", new[] { "CTPXs_STTPX" });
            DropIndex("dbo.MATHANGs", new[] { "CTPXs_STTPX" });
            DropIndex("dbo.MATHANGs", new[] { "CTPNs_STTPN" });
            DropColumn("dbo.PHIEUXUATs", "CTPXs_STTPX");
            DropColumn("dbo.PHIEUNHAPs", "CTPNs_STTPN");
            DropColumn("dbo.NHACUNGCAPs", "CTPXs_STTPX");
            DropColumn("dbo.NHACUNGCAPs", "CTPNs_STTPN");
            DropColumn("dbo.MATHANGs", "CTPXs_STTPX");
            DropColumn("dbo.MATHANGs", "CTPNs_STTPN");
            DropColumn("dbo.KHOHANGs", "TRONGKHOs_STT");
            DropColumn("dbo.KHACHHANGs", "CTPXs_STTPX");
            RenameTable(name: "dbo.KHOHANGs", newName: "KHHOHANGs");
        }
    }
}
