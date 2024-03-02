using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTaxAndTotal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "OrderTotal",
                table: "orderMenus",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "orderMenus",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "orderMenus");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "orderMenus");
        }
    }
}
