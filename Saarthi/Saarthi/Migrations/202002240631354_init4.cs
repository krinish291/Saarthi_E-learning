namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "Sub_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "Sub_Name");
        }
    }
}
