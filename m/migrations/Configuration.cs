namespace m.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using m.Models;
    using WebMatrix.WebData;
    using System.Data.Entity.Infrastructure;
    using System.Threading;
    using System.Web.Mvc;

    internal sealed class Configuration : DbMigrationsConfiguration<m.Models.mDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //  AutomaticMigrationsEnabled = true ;
        }

        protected override void Seed(mDBContext context)
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
        }
    }
}
