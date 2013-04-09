namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig_project_manager_add : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "ProjectManager_ID", "dbo.Employees");
            DropIndex("dbo.Projects", new[] { "ProjectManager_ID" });
            RenameColumn(table: "dbo.Projects", name: "ProjectManager_ID", newName: "ProjectManagerID");
            AddForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees", "ID", cascadeDelete: true);
            CreateIndex("dbo.Projects", "ProjectManagerID");
        }

        public override void Down()
        {
            DropIndex("dbo.Projects", new[] { "ProjectManagerID" });
            DropForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees");
            RenameColumn(table: "dbo.Projects", name: "ProjectManagerID", newName: "ProjectManager_ID");
            CreateIndex("dbo.Projects", "ProjectManager_ID");
            AddForeignKey("dbo.Projects", "ProjectManager_ID", "dbo.Employees", "ID");
        }
    }
}
