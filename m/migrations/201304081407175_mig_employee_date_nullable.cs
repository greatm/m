namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig_employee_date_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "DoJ", c => c.DateTime());
            AlterColumn("dbo.Employees", "DoJA", c => c.DateTime());
            AlterColumn("dbo.Employees", "DoI", c => c.DateTime());
            AlterColumn("dbo.Employees", "DoSalary", c => c.DateTime());
            AlterColumn("dbo.Employees", "DoL", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.Employees", "DoL", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "DoSalary", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "DoI", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "DoJA", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "DoJ", c => c.DateTime(nullable: false));
        }
    }
}
