using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.DAL.Repository;
using JobPortalCoreApi.Entity.Models;

namespace JobPortalCore.BAL.services
{
    public class JobDetailsService
    {
        IJobDetailsRepository _jobRepository;
        public JobDetailsService(IJobDetailsRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        //add movie
        public void AddJob(JobDetails job)
        {
            _jobRepository.AddJob(job);
        }
        //update movie
        public void UpdateJob(JobDetails job)
        {
            _jobRepository.UpdateJob(job);
        }
        //delete movie
        public void DeleteJob(int jobid)
        {
            _jobRepository.DeleteJob(jobid);
        }
        //Get GetMovieByid
        public void GetJobByid(int jobid)
        {
            _jobRepository.GetJobById(jobid);
        }
        //Get GetMovies
        public void GetJob()
        {
            _jobRepository.GetJobs();
        }
    }
}
