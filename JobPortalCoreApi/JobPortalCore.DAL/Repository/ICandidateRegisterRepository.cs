using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.Entity.Models;

namespace JobPortalCore.DAL.Repository
{
    public interface ICandidateRegisterRepository
    {
        
    
            void Register(CandidateRegister candidateRegister);
            CandidateRegister Login(CandidateRegister candidate);
        

    }
}
