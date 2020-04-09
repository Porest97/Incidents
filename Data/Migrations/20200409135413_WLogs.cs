using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Incidents.Data.Migrations
{
    public partial class WLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "NetelloLog");

            //migrationBuilder.DropTable(
            //    name: "WorkLog");

            //migrationBuilder.DropTable(
            //    name: "WorkLogStatus");

            migrationBuilder.CreateTable(
                name: "WLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WLNumber = table.Column<string>(nullable: true),
                    Hours = table.Column<decimal>(nullable: false),
                    DateTimeFrom = table.Column<DateTime>(nullable: false),
                    DateTimeTo = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WLog");

            migrationBuilder.CreateTable(
                name: "NetelloLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    DateTimeEnded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeScheduledNext = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeStarted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoursSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncidentId = table.Column<int>(type: "int", nullable: true),
                    MtrKost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    PriceHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: true),
                    TotalKost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetelloLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetelloLog_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NetelloLog_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NetelloLog_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NetelloLog_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkLogStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkLogStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLogStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FEEExitsSite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FEEntersSite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IncidentId = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WLNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkLogStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkLog_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkLog_WorkLogStatus_WorkLogStatusId",
                        column: x => x.WorkLogStatusId,
                        principalTable: "WorkLogStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NetelloLog_CompanyId",
                table: "NetelloLog",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_NetelloLog_IncidentId",
                table: "NetelloLog",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_NetelloLog_PersonId",
                table: "NetelloLog",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_NetelloLog_PurchaseOrderId",
                table: "NetelloLog",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLog_IncidentId",
                table: "WorkLog",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLog_WorkLogStatusId",
                table: "WorkLog",
                column: "WorkLogStatusId");
        }
    }
}
