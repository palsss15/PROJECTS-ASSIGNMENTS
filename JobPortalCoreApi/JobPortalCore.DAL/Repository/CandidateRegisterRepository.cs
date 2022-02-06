using JobPortalCore.DAL.Data;
using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobPortalCore.DAL.Repository
{
    public class CandidateRegisterRepository : ICandidateRegisterRepository
    {
        private JobDbContext _jobDbContext;
        public CandidateRegisterRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }
        public CandidateRegister Login(CandidateRegister candidate)
        {
            CandidateRegister candidateRegister = null;
            var result = _jobDbContext.candidateRegister.Where(obj => obj.EmailId == candidate.EmailId && obj.Password == candidate.Password).ToList();
            if (result.Count > 0)
            {
                candidateRegister = result[0];
            }
            return candidateRegister;
        }

        public void Register(CandidateRegister candidateRegister)
        {
            _jobDbContext.candidateRegister.Add(candidateRegister);
            _jobDbContext.SaveChanges();
        }
    }
}
