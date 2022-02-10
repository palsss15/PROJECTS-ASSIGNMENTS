using JobPortalCore.DAL.Data;
using JobPortalCore.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        public IConfiguration _configuration;
        private readonly JobDbContext _context;

        public TokenController(IConfiguration config, JobDbContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Post(CandidateRegister candidateRegister)
        {

            if (candidateRegister !=null && candidateRegister.EmailId != null && candidateRegister.Password != null)
            {
                var user = await GetUser(candidateRegister.EmailId, candidateRegister.Password);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.CandidateId.ToString()),
                    new Claim("Firstname", user.Firstname),
                    new Claim("Lastname", user.Lastname),
                    new Claim("EmailId", user.EmailId),
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<CandidateRegister> GetUser(string email, string password)
        {
            CandidateRegister userInfo = null;
            var result = _context.candidateRegister.Where(u => u.EmailId == email && u.Password == password);
            foreach (var item in result)
            {
                userInfo = new CandidateRegister();
                userInfo.CandidateId = item.CandidateId;
                userInfo.Firstname = item.Firstname;
                userInfo.Lastname = item.Lastname;
                userInfo.EmailId = item.EmailId;
                userInfo.MobNumber = item.MobNumber;
            }
            return userInfo;

        }
    }
}
