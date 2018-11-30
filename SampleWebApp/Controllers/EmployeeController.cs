using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEmployee(Employee model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult EditEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditEmployee(Employee model)
        {
            return View(model);
        }
    }
}