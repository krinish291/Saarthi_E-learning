namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StandardId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Standards", t => t.StandardId)
                .Index(t => t.StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "StandardId", "dbo.Standards");
            DropIndex("dbo.Subjects", new[] { "StandardId" });
            DropTable("dbo.Subjects");
        }
    }
}
