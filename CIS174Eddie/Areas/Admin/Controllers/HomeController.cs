﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174Eddie.Models;
using Microsoft.EntityFrameworkCore;

namespace CIS174Eddie.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}