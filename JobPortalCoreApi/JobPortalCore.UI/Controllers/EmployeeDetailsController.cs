using JobPortalCore.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JobPortalCore.UI.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetailsController
        private IConfiguration _configuration;
        public EmployeeDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<EmployeeDetails> employees = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "EmployeeDetails/GetEmployeeDetails";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        employees = JsonConvert.DeserializeObject<IEnumerable<EmployeeDetails>>(result);

                    }

                }
            }
            return View(employees);

        }

        // GET: EmployeeDetailsController/Details/5
        public ActionResult Details(int contactId)
        {
            return View();
        }

        // GET: EmployeeDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeDetailsController/Create
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

        // GET: EmployeeDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeDetailsController/Edit/5
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

        // GET: EmployeeDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
