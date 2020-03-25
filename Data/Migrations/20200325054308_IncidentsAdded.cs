using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Incidents.Data.Migrations
{
    public partial class IncidentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IncidentPriority",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentPriorityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentPriority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncidentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncidentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incident",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentPriorityId = table.Column<int>(nullable: true),
                    IncidentStatusId = table.Column<int>(nullable: true),
                    IncidentTypeId = table.Column<int>(nullable: true),
                    InccidentTypeId = table.Column<int>(nullable: true),
                    IncidentNumber = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    Received = table.Column<DateTime>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    FEScheduled = table.Column<DateTime>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FEEntersSite = table.Column<DateTime>(nullable: true),
                    FEEExitsSite = table.Column<DateTime>(nullable: true),
                    Logg = table.Column<string>(nullable: true),
                    IssueResolved = table.Column<DateTime>(nullable: true),
                    Resolution = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incident", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incident_IncidentType_InccidentTypeId",
                        column: x => x.InccidentTypeId,
                        principalTable: "IncidentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incident_IncidentPriority_IncidentPriorityId",
                        column: x => x.IncidentPriorityId,
                        principalTable: "IncidentPriority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incident_IncidentStatus_IncidentStatusId",
                        column: x => x.IncidentStatusId,
                        principalTable: "IncidentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incident_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incident_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incident_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incident_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incident_InccidentTypeId",
                table: "Incident",
                column: "InccidentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_IncidentPriorityId",
                table: "Incident",
                column: "IncidentPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_IncidentStatusId",
                table: "Incident",
                column: "IncidentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_PersonId",
                table: "Incident",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_PersonId1",
                table: "Incident",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_PersonId2",
                table: "Incident",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_SiteId",
                table: "Incident",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropTable(
                name: "IncidentType");

            migrationBuilder.DropTable(
                name: "IncidentPriority");

            migrationBuilder.DropTable(
                name: "IncidentStatus");
        }
    }
}
