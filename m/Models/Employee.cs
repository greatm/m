using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace m.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string eMail { get; set; }
        public int? DesignationID { get; set; }
        public Designation Designation { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }

        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        public string sex { get; set; }
        public string marrital_status { get; set; }

        public Nullable<DateTime> DoJ { get; set; }
        public Nullable<DateTime> DoJA { get; set; }
        public Nullable<DateTime> DoI { get; set; }
        public Nullable<DateTime> DoSalary { get; set; }
        public Nullable<DateTime> DoL { get; set; }
        public string reason_leave { get; set; }
        public string category { get; set; }
        public string division { get; set; }
        public string department { get; set; }
        public string grade { get; set; }
        public string Bank { get; set; }
        public string bank_account { get; set; }
        public string pf_no { get; set; }
        public string pf_no_dept { get; set; }
        public string esi_no { get; set; }
        public string esi_dispensary { get; set; }
        public bool? restrict_pf_contri { get; set; }
        public bool? zero_pension { get; set; }
        public bool? zero_pt { get; set; }
        public string PAN { get; set; }
        public string Ward { get; set; }
        public string AddressPresent { get; set; }
        public string AddressPermanent { get; set; }
        public string Remarks { get; set; }
    }
}