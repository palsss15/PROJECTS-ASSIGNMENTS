using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using JobPortalCore.DAL.Data;
using JobPortalCoreApi.Entity.Models;

namespace JobPortalCore.DAL.Repository
{
    public class JobDetailsRepository : IJobDetailsRepository
    {
        JobDbContext _jobDbContext;

        public JobDetailsRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }
        public void AddJob(JobDetails job)
        {
            _jobDbContext.jobs.Add(job);
            _jobDbContext.SaveChanges();
        }

        public void DeleteJob(int jobid)
        {
            var job = _jobDbContext.jobs.Find(jobid);
            _jobDbContext.jobs.Remove(job);
            _jobDbContext.SaveChanges();
        }

        public JobDetails GetJobById(int jobid)
        {
            return _jobDbContext.jobs.Find(jobid);
        }

        public IEnumerable<JobDetails> GetJobs()
        {
            return _jobDbContext.jobs.ToList();
        }

        public void UpdateJob(JobDetails job)
        {
            _jobDbContext.Entry(job).State = EntityState.Modified;
            _jobDbContext.SaveChanges();
        }
    }
}
