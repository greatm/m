namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class employee_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "UserName", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Employees", "UserName");
        }
    }
}
