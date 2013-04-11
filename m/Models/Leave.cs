using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema ;

namespace m.Models
{
    public class Leave
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int EmployeeID { get; set; }
        public Employee employee { get; set; }

        public int num_allowed { get; set; }
        public int num_taken { get; set; }
    }
}