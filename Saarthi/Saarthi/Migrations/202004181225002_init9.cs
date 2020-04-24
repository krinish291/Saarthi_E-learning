namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        QuizOn = c.DateTime(nullable: false),
                        Total = c.Int(nullable: false),
                        Obtained = c.Int(nullable: false),
                        chepter = c.String(),
                        Subject = c.String(),
                        std = c.String(),
                        LearnerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Learners", t => t.LearnerId)
                .Index(t => t.LearnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "LearnerId", "dbo.Learners");
            DropIndex("dbo.Results", new[] { "LearnerId" });
            DropTable("dbo.Results");
        }
    }
}
