using Microsoft.EntityFrameworkCore.Migrations;

namespace Incidents.Data.Migrations
{
    public partial class cctakenawayinIncidentTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incident_IncidentType_InccidentTypeId",
                table: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_Incident_InccidentTypeId",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "InccidentTypeId",
                table: "Incident");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_IncidentTypeId",
                table: "Incident",
                column: "IncidentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_IncidentType_IncidentTypeId",
                table: "Incident",
                column: "IncidentTypeId",
                principalTable: "IncidentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incident_IncidentType_IncidentTypeId",
                table: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_Incident_IncidentTypeId",
                table: "Incident");

            migrationBuilder.AddColumn<int>(
                name: "InccidentTypeId",
                table: "Incident",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incident_InccidentTypeId",
                table: "Incident",
                column: "InccidentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_IncidentType_InccidentTypeId",
                table: "Incident",
                column: "InccidentTypeId",
                principalTable: "IncidentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
