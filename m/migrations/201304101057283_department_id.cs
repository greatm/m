namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class department_id : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "Designation_ID", newName: "DesignationID");
            AddColumn("dbo.Employees", "eMail", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Employees", "eMail");
            RenameColumn(table: "dbo.Employees", name: "DesignationID", newName: "Designation_ID");
        }
    }
}
