using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalCore.Entity.Models
{
    public class EmployeeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        public string EmpName { get; set; }
        public int ContactNum { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
