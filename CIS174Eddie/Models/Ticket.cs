using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CIS174Eddie.Models
{
    // Required fields will be entered in by user
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a point value.")]
        public string PointId { get; set; }
        public Point Point { get; set; }

        [Required(ErrorMessage = "Please enter a status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }
    }
}
