using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace m.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee ProjectManager { get; set; }
    }
}