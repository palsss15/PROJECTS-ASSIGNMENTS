using JobPortalCore.DAL.Repository;
using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalCore.BAL.services
{
    public class EmployeeDetailsService
    {
        IEmployeeDetailsRepository _employeeDetailsRepository;
        public EmployeeDetailsService(IEmployeeDetailsRepository employeeDetailsRepository)
        {
            _employeeDetailsRepository = employeeDetailsRepository;

        }
        public void AddCandidateRegister(CandidateRegister candidateRegister)
        {
            _employeeDetailsRepository.AddCandidateRegister(candidateRegister);
        }
        public void UpdateCandidateRegister(CandidateRegister candidateRegister)
        {
            _employeeDetailsRepository.UpdateCandidateRegister(candidateRegister);
        }
        public void DeleteEmployee(int CandidateId)
        {
            _employeeDetailsRepository.DeleteCandidateRegister(CandidateId);
        }
        public CandidateRegister GetCandidateRegisterByID(int CandidateId)
        {
            return _employeeDetailsRepository.GetCandidateRegisterByID(CandidateId);

        }
        public IEnumerable<CandidateRegister> GetCandidateRegister()
        {
            return _employeeDetailsRepository.GetCandidateRegister();
        }

        public void Register(EmployeeDetails employeeDetails)
        {
             _employeeDetailsRepository.Register(employeeDetails);
        }

        public EmployeeDetails Login(EmployeeDetails employee)
        {
            return _employeeDetailsRepository.Login(employee);
        }


        public void AddEmployee(EmployeeDetails employee)
        {
            _employeeDetailsRepository.AddEmployee(employee);
        }

        public void UpdateEmployee(EmployeeDetails employee)
        {
            _employeeDetailsRepository.UpdateEmployee(employee);
        }

        public void DeleteEmployees(int contactId)
        {
            _employeeDetailsRepository.DeleteEmployees(contactId);
        }
        
        public EmployeeDetails GetJobByid(int contactId)
        {
            return _employeeDetailsRepository.GetEmployeeDetailsByID(contactId);
        }

        public IEnumerable<EmployeeDetails> GetEmployeeDetails()
        {
            return _employeeDetailsRepository.GetEmployeeDetails();
        }
    }
}
