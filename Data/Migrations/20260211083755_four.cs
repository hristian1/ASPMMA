using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPMMA.Data.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_shoppingCarts_UserId",
                table: "shoppingCarts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "orderStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCarts_UserId",
                table: "shoppingCarts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_shoppingCarts_UserId",
                table: "shoppingCarts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "orderStatuses");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCarts_UserId",
                table: "shoppingCarts",
                column: "UserId",
                unique: true);
        }
    }
}
