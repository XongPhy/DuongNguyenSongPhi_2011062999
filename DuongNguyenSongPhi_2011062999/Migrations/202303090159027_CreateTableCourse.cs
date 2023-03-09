namespace DuongNguyenSongPhi_2011062999.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        LecturerID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerID)
                .Index(t => t.CategoryId)
                .Index(t => t.LecturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LecturerID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "LecturerID" });
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
