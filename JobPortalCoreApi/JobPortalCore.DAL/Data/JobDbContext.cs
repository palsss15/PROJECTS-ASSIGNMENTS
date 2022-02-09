
using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.Entity.Models;
//using JobPortalCore.Entity.Models;
using JobPortalCoreApi.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortalCore.DAL.Data
{
    public class JobDbContext : DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext> options) : base (options)
        {

        }

        public DbSet<CandidateLogin> candidateLogin { get; set; }
        public DbSet<CandidateRegister> candidateRegister { get; set; }
        public DbSet<EmployeeDetails> employeeDetails { get; set; }
        public DbSet<JobDetails> jobs { get; set; }
        

    }

}
