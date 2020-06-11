using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174Eddie.Models;
using Microsoft.EntityFrameworkCore;

namespace CIS174Eddie.Controllers
{
    public class ContactHomeController : Controller
    {
        private ContactContext context { get; set; }

        public ContactHomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}