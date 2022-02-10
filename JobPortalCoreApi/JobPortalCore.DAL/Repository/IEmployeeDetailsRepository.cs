//using JobPortalCore.DAL.Migrations;
using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalCore.DAL.Repository
{
    public interface IEmployeeDetailsRepository
    {
        void AddCandidateRegister(CandidateRegister candidateRegister);
        void UpdateCandidateRegister(CandidateRegister candidateRegister);
        void DeleteCandidateRegister(int CandidateId);
        void AddEmployee(EmployeeDetails employeeDetails);
        
        void DeleteEmployees(int ContactId);
        void UpdateEmployee(EmployeeDetails employeeDetails);
        CandidateRegister GetCandidateRegisterByID(int CandidateId);

        EmployeeDetails GetEmployeeDetailsByID(int ContactId);
        IEnumerable<Entity.Models.CandidateRegister> GetCandidateRegister();
        IEnumerable<Entity.Models.EmployeeDetails> GetEmployeeDetails();
        void Register(EmployeeDetails employeeDetails);
        EmployeeDetails Login(EmployeeDetails employee);

    }
}
