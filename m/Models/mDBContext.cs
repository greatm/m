﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace m.Models
{
    public class mDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<ConveyanceMode> ConveyanceModes { get; set; }
        public DbSet<Leave> Leaves { get; set; }
    }
}