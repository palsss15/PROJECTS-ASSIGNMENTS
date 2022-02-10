using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalCore.Entity.Models
{
    public class CandidateRegister
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandidateId { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailId { get; set; }
        public int MobNumber { get; set; }
        public string QualificationDeg { get; set; }
        public string TechnicalSkills { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
       
    }
}
