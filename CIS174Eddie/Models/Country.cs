using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174Eddie.Models
{
    public class Country
    {
        public string CountryID { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; }
        public Category Category { get; set; }
        public string FlagImage { get; set; }
    }
}
