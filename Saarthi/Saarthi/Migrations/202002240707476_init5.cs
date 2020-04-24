namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Chp_Name = c.String(),
                        SubjectId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .Index(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chapters", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.Chapters", new[] { "SubjectId" });
            DropTable("dbo.Chapters");
        }
    }
}
