using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174Eddie.Migrations.Country
{
    public partial class Country2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "FlagImage", "GameID", "Name" },
                values: new object[,]
                {
                    { "swe", "indoor", "flag-of-Sweden.png", "wo", "Sweden" },
                    { "fin", "outdoor", "flag-of-Finland.png", "yo", "Finland" },
                    { "rus", "indoor", "flag-of-Russia.png", "yo", "Russia" },
                    { "cyp", "indoor", "flag-of-Cyprus.png", "yo", "Cyprus" },
                    { "fra", "indoor", "flag-of-France.png", "yo", "France" },
                    { "zim", "outdoor", "flag-of-Zimbabwe.png", "para", "Zimbabwe" },
                    { "pak", "outdoor", "flag-of-Pakistan.png", "para", "Pakistan" },
                    { "aus", "outdoor", "flag-of-Austria.png", "para", "Austria" },
                    { "ukr", "indoor", "flag-of-Ukraine.png", "para", "Ukraine" },
                    { "uru", "indoor", "flag-of-Uruguay.png", "para", "Uruguay" },
                    { "slo", "outdoor", "flag-of-Slovakia.png", "yo", "Slovakia" },
                    { "tha", "indoor", "flag-of-Thailand.png", "para", "Thailand" },
                    { "net", "outdoor", "flag-of-Netherlands.png", "so", "Netherlands" },
                    { "bra", "outdoor", "flag-of-Brazil.png", "so", "Brazil" },
                    { "mex", "indoor", "flag-of-Mexic.png", "so", "Mexico" },
                    { "chi", "indoor", "flag-of-China.png", "so", "China" },
                    { "ger", "indoor", "flag-of-Germany.png", "so", "Germany" },
                    { "jap", "outdoor", "flag-of-Japan.png", "wo", "Japan" },
                    { "ita", "outdoor", "flag-of-Italy.png", "wo", "Italy" },
                    { "jam", "outdoor", "flag-of-Jamaica.png", "wo", "Jamaica" },
                    { "gre", "indoor", "flag-of-United-Kingdom.png", "wo", "Great Britain" },
                    { "usa", "outdoor", "flag-of-United-States-of-America.png", "so", "USA" },
                    { "por", "outdoor", "flag-of-Portugal.png", "yo", "Portugal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "aus");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "bra");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "chi");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cyp");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fin");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "fra");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ger");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "gre");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ita");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jam");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jap");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mex");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "net");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pak");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "por");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "rus");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "slo");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "swe");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "tha");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ukr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uru");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "usa");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zim");
        }
    }
}
