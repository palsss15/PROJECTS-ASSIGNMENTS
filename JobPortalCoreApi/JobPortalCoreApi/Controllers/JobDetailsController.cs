using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalCore.BAL.Services;
using JobPortalCore.Entity.Models;
using JobPortalCore.BAL.services;
using JobPortalCoreApi.Entity.Models;

namespace JobPortalCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobDetailsController : ControllerBase
    {
        private JobDetailsService _jobDetailsService;
        public JobDetailsController(JobDetailsService jobDetailsService)
        {
            _jobDetailsService = jobDetailsService;
        }
        [HttpGet("GetJobs")]
        public IEnumerable<JobDetails> GetJobs()
        {
            return _jobDetailsService.GetJobs();
        }


        [HttpPost("AddJob")]
        public IActionResult AddJob([FromBody] JobDetails jobDetails)
        {
            _jobDetailsService.AddJob(jobDetails);
            return Ok("Job created successfully!!");
        }
        [HttpDelete("DeleteJob")]
        public IActionResult DeleteJob(int JobId)
        {
            _jobDetailsService.DeleteJob(JobId);
            return Ok("Job deleted successfully!!");
        }
        [HttpPut("UpdateJob")]
        public IActionResult UpdateJob([FromBody] JobDetails jobDetails)
        {
            _jobDetailsService.UpdateJob(jobDetails);
            return Ok("Job updated successfully!!");
        }
    }

}
