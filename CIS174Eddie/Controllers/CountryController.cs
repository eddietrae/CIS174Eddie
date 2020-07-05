using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CIS174Eddie.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174Eddie.Controllers
{
    public class CountryController : Controller
    {
        private CountryContext context;

        public CountryController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeGame = "all", string activeCat = "all")
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveCat(activeCat);

            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCat = activeCat,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeCat != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCat.ToLower());

            model.Countries = query.ToList();
            return View(model);
        }

        public ViewResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(c => c.Game)
                    .Include(c => c.Category)
                    .FirstOrDefault(c => c.CountryID == id),
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Category)
                .Where(c => c.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }
    }
}