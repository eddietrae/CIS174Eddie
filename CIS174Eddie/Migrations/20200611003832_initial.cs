using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174Eddie.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNum = table.Column<string>(maxLength: 15, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Note = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "Name", "Note", "PhoneNum" },
                values: new object[] { 1, "123 River Road", "Trae Eddie", "Cool guy", "555-111-2222" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "Name", "Note", "PhoneNum" },
                values: new object[] { 2, "123 Flint Road", "Jackie Moon", "Team owner and power forward", "555-222-3333" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
