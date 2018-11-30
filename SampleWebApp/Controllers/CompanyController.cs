using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult AddNewCompany()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCompany(Company model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult EditCompany(int companyId)
        {
            Company model = new Company();
            model.Name = "jakieś dane";
            return View(model);
        }

        [HttpPost]
        public IActionResult EditCompany(Company model)
        {
            return View(model);
        }
    }
}