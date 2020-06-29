using Microsoft.EntityFrameworkCore;

namespace CIS174Eddie.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Builds connection string to azure db
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174tmeddie.database.windows.net,1433;Initial Catalog=CIS174;Persist Security Info=False;User ID=tmeddie;Password=SPxw55RvhUmX6JH;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seeding
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "para", Name = "Paralympics" },
                new Game { GameID = "so", Name = "Summer Olympics" },
                new Game { GameID = "wo", Name = "Winter Olympics" },
                new Game { GameID = "yo", Name = "Youth Olympic Games" });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
                );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "can", Name = "Canada", GameID = "wo", CategoryID = "indoor", FlagImage = "flag-of-Canada.png" },
                new { CountryID = "swe", Name = "Sweden", GameID = "wo", CategoryID = "indoor", FlagImage = "flag-of-Sweden.png" },
                new { CountryID = "gre", Name = "Great Britain", GameID = "wo", CategoryID = "indoor", FlagImage = "flag-of-United-Kingdom.png" },
                new { CountryID = "jam", Name = "Jamaica", GameID = "wo", CategoryID = "outdoor", FlagImage = "flag-of-Jamaica.png" },
                new { CountryID = "ita", Name = "Italy", GameID = "wo", CategoryID = "outdoor", FlagImage = "flag-of-Italy.png" },
                new { CountryID = "jap", Name = "Japan", GameID = "wo", CategoryID = "outdoor", FlagImage = "flag-of-Japan.png" },
                new { CountryID = "ger", Name = "Germany", GameID = "so", CategoryID = "indoor", FlagImage = "flag-of-Germany.png" },
                new { CountryID = "chi", Name = "China", GameID = "so", CategoryID = "indoor", FlagImage = "flag-of-China.png" },
                new { CountryID = "mex", Name = "Mexico", GameID = "so", CategoryID = "indoor", FlagImage = "flag-of-Mexico.png" },
                new { CountryID = "bra", Name = "Brazil", GameID = "so", CategoryID = "outdoor", FlagImage = "flag-of-Brazil.png" },
                new { CountryID = "net", Name = "Netherlands", GameID = "so", CategoryID = "outdoor", FlagImage = "flag-of-Netherlands.png" },
                new { CountryID = "usa", Name = "USA", GameID = "so", CategoryID = "outdoor", FlagImage = "flag-of-United-States-of-America.png" },
                new { CountryID = "tha", Name = "Thailand", GameID = "para", CategoryID = "indoor", FlagImage = "flag-of-Thailand.png" },
                new { CountryID = "uru", Name = "Uruguay", GameID = "para", CategoryID = "indoor", FlagImage = "flag-of-Uruguay.png" },
                new { CountryID = "ukr", Name = "Ukraine", GameID = "para", CategoryID = "indoor", FlagImage = "flag-of-Ukraine.png" },
                new { CountryID = "aus", Name = "Austria", GameID = "para", CategoryID = "outdoor", FlagImage = "flag-of-Austria.png" },
                new { CountryID = "pak", Name = "Pakistan", GameID = "para", CategoryID = "outdoor", FlagImage = "flag-of-Pakistan.png" },
                new { CountryID = "zim", Name = "Zimbabwe", GameID = "para", CategoryID = "outdoor", FlagImage = "flag-of-Zimbabwe.png" },
                new { CountryID = "fra", Name = "France", GameID = "yo", CategoryID = "indoor", FlagImage = "flag-of-France.png" },
                new { CountryID = "cyp", Name = "Cyprus", GameID = "yo", CategoryID = "indoor", FlagImage = "flag-of-Cyprus.png" },
                new { CountryID = "rus", Name = "Russia", GameID = "yo", CategoryID = "indoor", FlagImage = "flag-of-Russia.png" },
                new { CountryID = "fin", Name = "Finland", GameID = "yo", CategoryID = "outdoor", FlagImage = "flag-of-Finland.png" },
                new { CountryID = "slo", Name = "Slovakia", GameID = "yo", CategoryID = "outdoor", FlagImage = "flag-of-Slovakia.png" },
                new { CountryID = "por", Name = "Portugal", GameID = "yo", CategoryID = "outdoor", FlagImage = "flag-of-Portugal.png" });
        }
    }
}
