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
        public string Father { get; set; }
        public string Mother { get; set; }
        public DateTime DoB { get; set; }
        public string sex { get; set; }
        public string marrital_status { get; set; }
        public DateTime DoJ { get; set; }
        public DateTime DoJA { get; set; }
        public DateTime DoI { get; set; }
        public DateTime DoSalary { get; set; }
        public DateTime DoL { get; set; }
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
        public bool restrict_pf_contri { get; set; }
        public bool zero_pension { get; set; }
        public bool zero_pt { get; set; }
        public string PAN { get; set; }
        public string Ward { get; set; }
        public string AddressPresent { get; set; }
        public string AddressPermanent { get; set; }
        public string Remarks { get; set; }
    }
}