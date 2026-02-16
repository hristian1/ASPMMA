using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPMMA.Data.Migrations
{
    /// <inheritdoc />
    public partial class fourp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ordersId",
                table: "orderStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orderStatuses_ordersId",
                table: "orderStatuses",
                column: "ordersId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderStatuses_orders_ordersId",
                table: "orderStatuses",
                column: "ordersId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderStatuses_orders_ordersId",
                table: "orderStatuses");

            migrationBuilder.DropIndex(
                name: "IX_orderStatuses_ordersId",
                table: "orderStatuses");

            migrationBuilder.DropColumn(
                name: "ordersId",
                table: "orderStatuses");
        }
    }
}
