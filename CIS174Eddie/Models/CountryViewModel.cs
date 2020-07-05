using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace CIS174Eddie.Models
{
    public class CountryViewModel
    {
        public Country Country { get; set; }
        public string ActiveGame { get; set; } = "all";
        public string ActiveCat { get; set; } = "all";
    }
}
