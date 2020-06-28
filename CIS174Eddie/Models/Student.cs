using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIS174Eddie.Models
{
    public class Student
    {
        public string FirstName { get; set;}
        public string LastName { get; set; }
        [RegularExpression(@"^[ABCDF]{1}")]
        public string Grade { get; set; }
    }
}
