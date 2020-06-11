using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
/***************************************************************
* Name        : CIS 174
* Author      : Trae Eddie
* Created     : 6/5/2020
***************************************************************/
namespace CIS174Eddie.Models
{
    /**************************************************************
	* Name: Contact
	* Description: Sets properties for Contact objects
	* Input: none
	***************************************************************/
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
        public string Name { get; set; }

        [StringLength(15, ErrorMessage = "Phone Number must be 15 characters or less")]
        public string PhoneNum { get; set; }

        [StringLength(500, ErrorMessage = "Address must be 500 characters or less.")]
        public string Address { get; set; }

        [StringLength(1000, ErrorMessage = "Name must be less than 50 characters or less.")]
        public string Note { get; set; }

        // Url Slug
        public string Slug =>
            Name?.Replace(' ', '-').ToLower();
    }
}
