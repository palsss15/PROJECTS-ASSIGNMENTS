using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalCore.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using JobPortalCoreApi.Entity.Models;

namespace JobPortalCore.UI.Controllers
{
    public class JobDetailsController : Controller
    {
        private IConfiguration _configuration;
        public JobDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<JobDetails> jobs = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "JobDetails/GetJobs";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        jobs = JsonConvert.DeserializeObject<IEnumerable<JobDetails>>(result);

                    }

                }
            }
            return View(jobs);
        }

        // GET: JobDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobDetails/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobDetails/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobDetails/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            JobDetails jobDetails = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:40275");
                HttpResponseMessage httpResponse = await client.GetAsync("/api/JobDetails/" + id);
                if (httpResponse.IsSuccessStatusCode)
                {
                    var loanResponse = httpResponse.Content.ReadAsStringAsync().Result;
                    jobDetails = JsonConvert.DeserializeObject<JobDetails>(loanResponse);
                }
            }
            return View();

        }

        // POST: JobDetails/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:40275");
                    HttpResponseMessage httpResponse = await client.DeleteAsync("/api/JobDetails/" + id);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }


            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}
