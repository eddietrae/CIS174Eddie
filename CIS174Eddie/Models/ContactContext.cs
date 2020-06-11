using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
/***************************************************************
* Name        : CIS 174
* Author      : Trae Eddie
* Created     : 6/5/2020
***************************************************************/
namespace CIS174Eddie.Models
{
    /**************************************************************
	* Name: ContactContext
	* Description: Sets up db with table Contacts based on the Contact class.
    * Sets the connection string and seeding for Contact entities.
	* Input: none
	***************************************************************/
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        // Builds connection string to azure db
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174tmeddie.database.windows.net,1433;Initial Catalog=CIS174;Persist Security Info=False;User ID=tmeddie;Password=SPxw55RvhUmX6JH;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        // DB seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    Name = "Trae Eddie",
                    PhoneNum = "555-111-2222",
                    Address = "123 River Road",
                    Note = "Cool guy"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Jackie Moon",
                    PhoneNum = "555-222-3333",
                    Address = "123 Flint Road",
                    Note = "Team owner and power forward"
                }
            );
        }
    }
}
