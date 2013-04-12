namespace m.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMatrix.WebData;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<m.Models.mDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(m.Models.mDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            SeedMembership();
        }

        private void SeedMembership()
        {
            //WebSecurity.InitializeDatabaseConnection("DefaultConnection",
            //    "UserProfile", "UserId", "UserName", autoCreateTables: true);


            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }
            if (!roles.RoleExists("Executive"))
            {
                roles.CreateRole("Executive");
            }
            if (!roles.RoleExists("Approver"))
            {
                roles.CreateRole("Approver");
            }
            if (!roles.RoleExists("Accounts"))
            {
                roles.CreateRole("Accounts");
            }
            if (!roles.RoleExists("Management"))
            {
                roles.CreateRole("Management");
            }
            if (membership.GetUser("a", false) == null)
            {
                membership.CreateUserAndAccount("a", "123456");
            }
            if (!roles.GetRolesForUser("a").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "a" }, new[] { "admin" });
            }
            if (membership.GetUser("e", false) == null)
            {
                membership.CreateUserAndAccount("e", "123456");
            }
            if (!roles.GetRolesForUser("e").Contains("Executive"))
            {
                roles.AddUsersToRoles(new[] { "e" }, new[] { "Executive" });
            }
        }
    }
}
