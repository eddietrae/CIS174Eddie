using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174Eddie.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }
        

        // Making the first item in the list 'all' for both game and category
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Game { GameID = "all", Name = "All" });
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0, new Category { CategoryID = "all", Name = "All" });
            }
        }

        // Determine the active link
        public string CheckActiveGame(string g) => g.ToLower() == ActiveGame.ToLower() ? "active" : "";

        public string CheckActiveCat(string c) => c.ToLower() == ActiveCat.ToLower() ? "active" : "";
    }
}
