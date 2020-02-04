namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Learners",
                c => new
                    {
                        LearnerId = c.String(nullable: false, maxLength: 128),
                        F_Name = c.String(),
                        L_Name = c.String(),
                        M_Name = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        confPassWord = c.String(),
                    })
                .PrimaryKey(t => t.LearnerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Learners");
        }
    }
}
