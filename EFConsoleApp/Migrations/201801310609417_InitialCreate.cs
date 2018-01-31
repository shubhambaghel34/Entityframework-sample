namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectiD = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectiD)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "Student_StudentID" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
        }
    }
}
