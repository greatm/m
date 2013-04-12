using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace m.Models
{
    //public class UsersContext : DbContext
    //{
    //    public UsersContext()
    //        : base("DefaultConnection")
    //    {
    //    }

    //    public DbSet<UserProfile> UserProfiles { get; set; }
    //}

    //[Table("UserProfile")]
    //public class UserProfile
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int UserId { get; set; }
    //    public string UserName { get; set; }
    //}

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

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

        public int? GradeID { get; set; }
        public Grade grade { get; set; }
        public Nullable<DateTime> DoJ { get; set; }
        public Nullable<DateTime> DoJA { get; set; }
        public Nullable<DateTime> DoI { get; set; }
        public Nullable<DateTime> DoSalary { get; set; }
        public Nullable<DateTime> DoL { get; set; }
        public string reason_leave { get; set; }
        public string category { get; set; }
        public string division { get; set; }
        public string department { get; set; }
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

        public RegisterModel(Employee emp)
        {
            this.UserName = emp.UserName;

            this.FirstName = emp.FirstName;
            this.LastName = emp.LastName;
            this.Mobile = emp.Mobile;
            this.eMail = emp.eMail;
            this.DesignationID = emp.DesignationID;
            this.Father = emp.Father;
            this.Mother = emp.Mother;
            this.DoB = emp.DoB;
            this.sex = emp.sex;
            this.marrital_status = emp.marrital_status;
            this.GradeID = emp.GradeID;
            this.DoJ = emp.DoJ;
            this.DoJA = emp.DoJA;
            this.DoI = emp.DoI;
            this.DoSalary = emp.DoSalary;
            this.DoL = emp.DoL;
            this.reason_leave = emp.reason_leave;
            this.category = emp.category;
            this.division = emp.division;
            this.department = emp.department;
            this.Bank = emp.Bank;
            this.bank_account = emp.bank_account;
            this.pf_no = emp.pf_no;
            this.pf_no_dept = emp.pf_no_dept;
            this.esi_no = emp.esi_no;
            this.esi_dispensary = emp.esi_dispensary;
            this.restrict_pf_contri = emp.restrict_pf_contri;
            this.zero_pension = emp.zero_pension;
            this.zero_pt = emp.zero_pt;
            this.PAN = emp.PAN;
            this.Ward = emp.Ward;
            this.AddressPresent = emp.AddressPresent;
            this.AddressPermanent = emp.AddressPermanent;
            this.Remarks = emp.Remarks;
        }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
