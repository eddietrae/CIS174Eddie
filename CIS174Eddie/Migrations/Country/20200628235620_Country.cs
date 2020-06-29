using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174Eddie.Migrations.Country
{
    public partial class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "FlagImage", "GameID", "Name" },
                values: new object[] { "can", "indoor", "flag-of-Canada.png", "wo", "Canada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "can");
        }
    }
}
