using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CIS174Eddie.Models
{
    /**************************************************************
	* Name: FutureAge
	* Description: Class with name and birth year properties and AgeThisYear method
	* Input: Name, BirthYear
	***************************************************************/
    public class FutureAge
    {
        public const int CURRENT_YEAR = 2020;

        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression(@"^[A-Za-z ]*$", ErrorMessage = "Please enter letters only in name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a birth year.")]
        [Range(1, 2020, ErrorMessage = "Birth year must be between 1-2020")]
        public int? BirthYear { get; set; }

        public int? AgeThisYear() // calculating age as of dec 31st, 2020 based on BirthYear property
        {
            return CURRENT_YEAR - BirthYear;
        }
    }
}
