using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.DAL.Repository;
using JobPortalCoreApi.Entity.Models;

namespace JobPortalCore.BAL.services
{
    public class JobDetailsService
    {
        private IJobDetailsRepository _jobRepository;
        public JobDetailsService(IJobDetailsRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

       
        public void AddJob(JobDetails job)
        {
            _jobRepository.AddJob(job);
        }
        
        public void UpdateJob(JobDetails job)
        {
            _jobRepository.UpdateJob(job);
        }
       
        public void DeleteJob(int jobid)
        {
            _jobRepository.DeleteJob(jobid);
        }
    
        public JobDetails GetJobByid(int jobid)
        {
          return  _jobRepository.GetJobById(jobid);
        }
     
        public IEnumerable<JobDetails> GetJobs()
        {
           return _jobRepository.GetJobs();
        }
    }
}
