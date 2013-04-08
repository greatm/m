using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace m.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public Designation Designation { get; set; }
    }
}