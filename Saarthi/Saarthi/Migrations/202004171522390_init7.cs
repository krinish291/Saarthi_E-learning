namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Questions", name: "ChepterId", newName: "ChapterId");
            RenameIndex(table: "dbo.Questions", name: "IX_ChepterId", newName: "IX_ChapterId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Questions", name: "IX_ChapterId", newName: "IX_ChepterId");
            RenameColumn(table: "dbo.Questions", name: "ChapterId", newName: "ChepterId");
        }
    }
}
