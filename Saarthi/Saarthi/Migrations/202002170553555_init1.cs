namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Learners", "PhotoURL", c => c.String(nullable: false));
            DropColumn("dbo.Learners", "confPassWord");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Learners", "confPassWord", c => c.String());
            DropColumn("dbo.Learners", "PhotoURL");
        }
    }
}
