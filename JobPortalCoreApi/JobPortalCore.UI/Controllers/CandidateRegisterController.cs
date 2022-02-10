using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JobPortalCore.Entity.Models;

namespace JobPortalCore.UI.Controllers
{
    public class CandidateRegisterController : Controller
    {
        private IConfiguration _configuration;
        public CandidateRegisterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(CandidateRegister candidateRegister)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(candidateRegister), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "CandidateRegister/Register";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        
                        ViewBag.status = "Ok";
                        ViewBag.message = "Register successfully!";
                        return Redirect("Login");
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(CandidateRegister candidateRegister)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(candidateRegister), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Token/Login";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    { 
                        //Session["Firstname"] = candidateRegister;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong credentials!";
                    }
                }
            }
            return View();
        }
    }
}