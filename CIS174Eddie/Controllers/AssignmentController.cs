using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS174Eddie.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index(int lvl = 1) // routing for different levels of access
        {
            ViewBag.lvl = lvl;
            return View();
        }
    }
}