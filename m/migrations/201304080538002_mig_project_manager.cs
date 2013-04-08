namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig_project_manager : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "ProjectManager_ID", c => c.Int());
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            AddColumn("dbo.Employees", "LastName", c => c.String());
            AddColumn("dbo.Employees", "Mobile", c => c.String());
            AddForeignKey("dbo.Projects", "ProjectManager_ID", "dbo.Employees", "ID");
            CreateIndex("dbo.Projects", "ProjectManager_ID");
            DropColumn("dbo.Employees", "Name");
        }

        public override void Down()
        {
            AddColumn("dbo.Employees", "Name", c => c.String());
            DropIndex("dbo.Projects", new[] { "ProjectManager_ID" });
            DropForeignKey("dbo.Projects", "ProjectManager_ID", "dbo.Employees");
            DropColumn("dbo.Employees", "Mobile");
            DropColumn("dbo.Employees", "LastName");
            DropColumn("dbo.Employees", "FirstName");
            DropColumn("dbo.Projects", "ProjectManager_ID");
        }
    }
}
