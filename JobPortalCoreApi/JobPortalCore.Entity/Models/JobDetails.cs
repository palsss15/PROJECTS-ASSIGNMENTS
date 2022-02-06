using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JobPortalCore.Entity.Models;

namespace JobPortalCoreApi.Entity.Models
{
    public class JobDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Jobid { get; set; }
        public string Jobtitle { get; set; }
        public string Joblocation { get; set; }
        public string Technicalskills { get; set; }
        public string Qualifications { get; set; }
        public string Companyname { get; set; }
        public string ContactPerson { get; set; }
        public int ContactNum { get; set; }

        public CandidateRegister candidateregister { get; set; }
        [ForeignKey("candidateregister")]

        public int CandidateId { get; set; }

        public EmployeeDetails employeedetails { get; set; }
        [ForeignKey("employeedetails")]

        public int ContactId { get; set; }



    }

}


