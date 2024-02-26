using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddCustomers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddCustomers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "orderMenus",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hamburger = table.Column<bool>(type: "bit", nullable: false),
                    Pizza = table.Column<bool>(type: "bit", nullable: false),
                    HotDog = table.Column<bool>(type: "bit", nullable: false),
                    Soda = table.Column<bool>(type: "bit", nullable: false),
                    Coffee = table.Column<bool>(type: "bit", nullable: false),
                    Tea = table.Column<bool>(type: "bit", nullable: false),
                    Subtotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderMenus", x => x.OrderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddCustomers");

            migrationBuilder.DropTable(
                name: "orderMenus");
        }
    }
}
