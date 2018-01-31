namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ModifiedDate");
        }
    }
}
