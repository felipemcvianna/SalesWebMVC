using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddSaleStatusToSalesRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SalesRecord",
                newName: "SaleStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SaleStatus",
                table: "SalesRecord",
                newName: "Status");
        }
    }
}
