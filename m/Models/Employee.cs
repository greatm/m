using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace m.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Designation Designation { get; set; }
    }
}