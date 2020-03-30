using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Incidents.Data.Migrations
{
    public partial class POAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderId",
                table: "Incident",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PONumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    POHours = table.Column<decimal>(nullable: false),
                    DateTimeApproved = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incident_PurchaseOrderId",
                table: "Incident",
                column: "PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_PurchaseOrder_PurchaseOrderId",
                table: "Incident",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incident_PurchaseOrder_PurchaseOrderId",
                table: "Incident");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_Incident_PurchaseOrderId",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "Incident");
        }
    }
}
