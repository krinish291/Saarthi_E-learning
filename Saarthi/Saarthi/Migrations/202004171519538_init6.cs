namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Statment = c.String(),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                        Correct = c.String(),
                        ChepterId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chapters", t => t.ChepterId)
                .Index(t => t.ChepterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "ChepterId", "dbo.Chapters");
            DropIndex("dbo.Questions", new[] { "ChepterId" });
            DropTable("dbo.Questions");
        }
    }
}
