using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174Eddie.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174Eddie.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat(),
                Countries = session.GetMyCountries()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            session.RemoveMyCountries();

            TempData["message"] = "Favorite countries cleared";

            return RedirectToAction("Index", "Country",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }
    }
}