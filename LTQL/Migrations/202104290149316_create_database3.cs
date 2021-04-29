namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.THONGTINs",
                c => new
                    {
                        ThongtinID = c.String(nullable: false, maxLength: 128),
                        Tieude = c.String(),
                        Noidung = c.String(),
                    })
                .PrimaryKey(t => t.ThongtinID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.THONGTINs");
        }
    }
}
