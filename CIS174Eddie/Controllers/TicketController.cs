using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174Eddie.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CIS174Eddie.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private TicketContext context;
        public TicketController(TicketContext ctx) => context = ctx;
        
        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.Points = context.Points.ToList();
            ViewBag.Statuses = context.Statuses.ToList();

            IQueryable<Ticket> query = context.Tickets
                .Include(t => t.Point).Include(t => t.Status);
            if (filters.HasPoint)
            {
                query = query.Where(t => t.PointId == filters.PointId);
            }
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            var tickets = query.OrderBy(t => t.Status).ToList();
            return View(tickets);
        }
        
        [HttpGet] // The Add methods add tickets with the Add view
        public IActionResult Add()
        {
            ViewBag.Points = context.Points.ToList();
            ViewBag.Statuses = context.Statuses.ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                context.Tickets.Add(ticket);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Points = context.Points.ToList();
                ViewBag.Statuses = context.Statuses.ToList();
                return View(ticket);
            }
        }
        
        [HttpPost] // uses filter class to sort the table
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost] // Allows tickets to be edited if they exist and then returns to index
        public IActionResult Edit([FromRoute] string id, Ticket selected)
        {
            if (selected.StatusId == null)
            {
                context.Tickets.Remove(selected);
            }
            else
            {
                string newStatusId = selected.StatusId;
                selected = context.Tickets.Find(selected.Id);
                selected.StatusId = newStatusId;
                context.Tickets.Update(selected);
            }
            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}