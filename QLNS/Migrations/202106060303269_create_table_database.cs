namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUCVUs",
                c => new
                    {
                        MaCV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenCV = c.String(),
                        MaNV = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.MaCV)
                .ForeignKey("dbo.NHANVIENs", t => t.MaNV)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNV = c.String(),
                        SDT = c.String(),
                        MaCV = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CHUCVUs", "MaNV", "dbo.NHANVIENs");
            DropIndex("dbo.CHUCVUs", new[] { "MaNV" });
            DropTable("dbo.NHANVIENs");
            DropTable("dbo.CHUCVUs");
        }
    }
}
