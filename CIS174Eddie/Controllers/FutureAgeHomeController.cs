using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174Eddie.Models;

namespace CIS174Eddie.Controllers
{
    public class FutureAgeHomeController : Controller
    {
        // Initial blank home view
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.output = "";
            return View();
        }

        // Ouput for home view based on FutureAge model
        [HttpPost]
        public IActionResult Index(FutureAge model)
        {
            if (ModelState.IsValid) // input validation via FutureAge model
            {
                ViewBag.Output = $"{model.Name} will be {model.AgeThisYear()} years old at the end of the year.";
            }
            else // Will return no output if input validation failed
            {
                ViewBag.Output = "";
            }

            return View(model);
        }
    }
}