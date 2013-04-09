namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class project_pmid_nullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees");
            DropIndex("dbo.Projects", new[] { "ProjectManagerID" });
            AlterColumn("dbo.Projects", "ProjectManagerID", c => c.Int());
            AddForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees", "ID");
            CreateIndex("dbo.Projects", "ProjectManagerID");
        }

        public override void Down()
        {
            DropIndex("dbo.Projects", new[] { "ProjectManagerID" });
            DropForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees");
            AlterColumn("dbo.Projects", "ProjectManagerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "ProjectManagerID");
            AddForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees", "ID", cascadeDelete: true);
        }
    }
}
