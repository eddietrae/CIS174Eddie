using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174Eddie.Models;
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
            // Store selected game and category IDs
            ViewBag.ActiveGame = activeGame;
            ViewBag.ActiveCat = activeCat;

            // Get games and categories from db
            List<Game> games = context.Games.ToList();
            List<Category> categories = context.Categories.ToList();

            // Add 'all' value to front of each list
            games.Insert(0, new Game { GameID = "all", Name = "All" });
            categories.Insert(0, new Category { CategoryID = "all", Name = "All" });

            // Store lists
            ViewBag.Games = games;
            ViewBag.Categories = categories;

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeCat != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCat.ToLower());

            var countries = query.ToList();
            return View(countries);
        }
    }
}