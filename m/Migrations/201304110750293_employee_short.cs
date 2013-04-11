namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class employee_short : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "DesignationID", "dbo.Designations");
            DropIndex("dbo.Employees", new[] { "DesignationID" });
            DropColumn("dbo.Employees", "DesignationID");
            DropColumn("dbo.Employees", "Father");
            DropColumn("dbo.Employees", "Mother");
            DropColumn("dbo.Employees", "DoB");
            DropColumn("dbo.Employees", "sex");
            DropColumn("dbo.Employees", "marrital_status");
            DropColumn("dbo.Employees", "DoJ");
            DropColumn("dbo.Employees", "DoJA");
            DropColumn("dbo.Employees", "DoI");
            DropColumn("dbo.Employees", "DoSalary");
            DropColumn("dbo.Employees", "DoL");
            DropColumn("dbo.Employees", "reason_leave");
            DropColumn("dbo.Employees", "category");
            DropColumn("dbo.Employees", "division");
            DropColumn("dbo.Employees", "department");
            DropColumn("dbo.Employees", "grade");
            DropColumn("dbo.Employees", "Bank");
            DropColumn("dbo.Employees", "bank_account");
            DropColumn("dbo.Employees", "pf_no");
            DropColumn("dbo.Employees", "pf_no_dept");
            DropColumn("dbo.Employees", "esi_no");
            DropColumn("dbo.Employees", "esi_dispensary");
            DropColumn("dbo.Employees", "restrict_pf_contri");
            DropColumn("dbo.Employees", "zero_pension");
            DropColumn("dbo.Employees", "zero_pt");
            DropColumn("dbo.Employees", "PAN");
            DropColumn("dbo.Employees", "Ward");
            DropColumn("dbo.Employees", "AddressPresent");
            DropColumn("dbo.Employees", "AddressPermanent");
            DropColumn("dbo.Employees", "Remarks");
        }

        public override void Down()
        {
            AddColumn("dbo.Employees", "Remarks", c => c.String());
            AddColumn("dbo.Employees", "AddressPermanent", c => c.String());
            AddColumn("dbo.Employees", "AddressPresent", c => c.String());
            AddColumn("dbo.Employees", "Ward", c => c.String());
            AddColumn("dbo.Employees", "PAN", c => c.String());
            AddColumn("dbo.Employees", "zero_pt", c => c.Boolean());
            AddColumn("dbo.Employees", "zero_pension", c => c.Boolean());
            AddColumn("dbo.Employees", "restrict_pf_contri", c => c.Boolean());
            AddColumn("dbo.Employees", "esi_dispensary", c => c.String());
            AddColumn("dbo.Employees", "esi_no", c => c.String());
            AddColumn("dbo.Employees", "pf_no_dept", c => c.String());
            AddColumn("dbo.Employees", "pf_no", c => c.String());
            AddColumn("dbo.Employees", "bank_account", c => c.String());
            AddColumn("dbo.Employees", "Bank", c => c.String());
            AddColumn("dbo.Employees", "grade", c => c.String());
            AddColumn("dbo.Employees", "department", c => c.String());
            AddColumn("dbo.Employees", "division", c => c.String());
            AddColumn("dbo.Employees", "category", c => c.String());
            AddColumn("dbo.Employees", "reason_leave", c => c.String());
            AddColumn("dbo.Employees", "DoL", c => c.DateTime());
            AddColumn("dbo.Employees", "DoSalary", c => c.DateTime());
            AddColumn("dbo.Employees", "DoI", c => c.DateTime());
            AddColumn("dbo.Employees", "DoJA", c => c.DateTime());
            AddColumn("dbo.Employees", "DoJ", c => c.DateTime());
            AddColumn("dbo.Employees", "marrital_status", c => c.String());
            AddColumn("dbo.Employees", "sex", c => c.String());
            AddColumn("dbo.Employees", "DoB", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "Mother", c => c.String());
            AddColumn("dbo.Employees", "Father", c => c.String());
            AddColumn("dbo.Employees", "DesignationID", c => c.Int());
            CreateIndex("dbo.Employees", "DesignationID");
            AddForeignKey("dbo.Employees", "DesignationID", "dbo.Designations", "ID");
        }
    }
}
