using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingApp.Migrations
{
    /// <inheritdoc />
    public partial class DeletedCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderMenus",
                table: "orderMenus");

            migrationBuilder.RenameTable(
                name: "orderMenus",
                newName: "OrderMenus");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "OrderMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMenus",
                table: "OrderMenus",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMenus",
                table: "OrderMenus");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderMenus");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "OrderMenus");

            migrationBuilder.RenameTable(
                name: "OrderMenus",
                newName: "orderMenus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderMenus",
                table: "orderMenus",
                column: "OrderId");

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
        }
    }
}
