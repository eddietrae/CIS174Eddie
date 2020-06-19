using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIS174Eddie.Models;

namespace CIS174Eddie.Controllers
{
    public class RouteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Custom(int num = 1)
        {
            return View();
        }

        [Route("Attribute")]
        public IActionResult Attribute()
        {
            return View();
        }
    }
}