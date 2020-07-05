using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace CIS174Eddie.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets { get; set; } // tables
        public DbSet<Point> Points { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174tmeddie.database.windows.net,1433;Initial Catalog=CIS174;Persist Security Info=False;User ID=tmeddie;Password=SPxw55RvhUmX6JH;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
        // Seeding. These will be drop down/select items for each ticket
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Point>().HasData(
                new Point { PointId = "1", PointValue = "1" },
                new Point { PointId = "2", PointValue = "2" },
                new Point { PointId = "3", PointValue = "3" },
                new Point { PointId = "5", PointValue = "5" },
                new Point { PointId = "8", PointValue = "8" },
                new Point { PointId = "13", PointValue = "13" },
                new Point { PointId = "21", PointValue = "21" }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "td", Name = "To Do" },
                new Status { StatusId = "ip", Name = "In Progress" },
                new Status { StatusId = "qa", Name = "Quality Assurance" },
                new Status { StatusId = "dn", Name = "Done" }
            );
                
        }
    }
}
