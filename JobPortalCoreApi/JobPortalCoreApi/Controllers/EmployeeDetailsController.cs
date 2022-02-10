using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalCore.BAL.services;
using JobPortalCoreApi.Entity.Models;
using JobPortalCore.Entity.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobPortalCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {

        private EmployeeDetailsService _employeeDetailsService;
        public EmployeeDetailsController(EmployeeDetailsService employeeDetailsService)
        {
            _employeeDetailsService = employeeDetailsService;
        }
        // GET: api/<EmployeeDetailsController>
        [HttpGet("GetEmployeeDetails")]
        public IEnumerable<EmployeeDetails> GetEmployeeDetails()
        {
            return _employeeDetailsService.GetEmployeeDetails();
        }

    
        

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] EmployeeDetails employeeDetails)
        {
            _employeeDetailsService.AddEmployee(employeeDetails);
            return Ok("Employee created successfully!!");
        }
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int contactId)
        {
            _employeeDetailsService.DeleteEmployee(contactId);
            return Ok("Employee deleted successfully!!");
        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] EmployeeDetails employeeDetails)
        {
            _employeeDetailsService.UpdateEmployee(employeeDetails);
            return Ok("Employee updated successfully!!");
        }
    }
}
