using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174Eddie.Models;
using Microsoft.EntityFrameworkCore;

namespace CIS174Eddie.Controllers
{
    public class MovieHomeController : Controller
    {
        private MovieContext movieContext { get; set; }

        public MovieHomeController(MovieContext ctx)
        {
            movieContext = ctx;
        }

        public IActionResult Index()
        {
            var movies = movieContext.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}