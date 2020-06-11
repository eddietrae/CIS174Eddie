using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174Eddie.Models;
/***************************************************************
* Name        : CIS 174
* Author      : Trae Eddie
* Created     : 6/5/2020
***************************************************************/
namespace CIS174Eddie.Controllers
{
    public class ContactController : Controller
    {

        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }

        // Sends user to the Add view with a blank contact
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Add", new Contact());
        }

        // Confirms the contact input is valid then adds it to the table and returns user to index view
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Contacts", "Home");
            }
            else // Invalid input
            {
                ViewBag.Action = "Add";
                return View(contact);
            }
        }
        // Sends user to the Delete view and brings the selected contact based on Id
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        // Removes the selected contact and returns the user to index view
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Contacts", "Home");
        }
    }
}