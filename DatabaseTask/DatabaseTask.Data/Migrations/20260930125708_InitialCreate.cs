using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crime",
                columns: table => new
                {
                    CrimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crime", x => x.CrimeID);
                });

            migrationBuilder.CreateTable(
                name: "Prison",
                columns: table => new
                {
                    PrisonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaximumCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prison", x => x.PrisonID);
                });

            migrationBuilder.CreateTable(
                name: "Punishment",
                columns: table => new
                {
                    PunishmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PunishmentType = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punishment", x => x.PunishmentID);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    BlockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonID = table.Column<int>(type: "int", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SecurityLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.BlockID);
                    table.ForeignKey(
                        name: "FK_Block_Prison_PrisonID",
                        column: x => x.PrisonID,
                        principalTable: "Prison",
                        principalColumn: "PrisonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingsID);
                    table.ForeignKey(
                        name: "FK_Building_Prison_PrisonID",
                        column: x => x.PrisonID,
                        principalTable: "Prison",
                        principalColumn: "PrisonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guards",
                columns: table => new
                {
                    GuardsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkerNumber = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guards", x => x.GuardsID);
                    table.ForeignKey(
                        name: "FK_Guards_Prison_PrisonID",
                        column: x => x.PrisonID,
                        principalTable: "Prison",
                        principalColumn: "PrisonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chamber",
                columns: table => new
                {
                    ChamberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockID = table.Column<int>(type: "int", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    floor = table.Column<int>(type: "int", nullable: false),
                    MaximumCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamber", x => x.ChamberID);
                    table.ForeignKey(
                        name: "FK_Chamber_Block_BlockID",
                        column: x => x.BlockID,
                        principalTable: "Block",
                        principalColumn: "BlockID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    ShiftID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guards_ID = table.Column<int>(type: "int", nullable: false),
                    GuardsID = table.Column<int>(type: "int", nullable: false),
                    Start_Time = table.Column<int>(type: "int", nullable: false),
                    Finish_Time = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.ShiftID);
                    table.ForeignKey(
                        name: "FK_Shift_Guards_GuardsID",
                        column: x => x.GuardsID,
                        principalTable: "Guards",
                        principalColumn: "GuardsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prisoners",
                columns: table => new
                {
                    PrisonerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChamberID = table.Column<int>(type: "int", nullable: false),
                    PunishmentID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalNumber = table.Column<int>(type: "int", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrisonerStatus = table.Column<bool>(type: "bit", nullable: false),
                    VisitorsID = table.Column<int>(type: "int", nullable: false),
                    CrimeID = table.Column<int>(type: "int", nullable: false),
                    VisitID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisoners", x => x.PrisonerID);
                    table.ForeignKey(
                        name: "FK_Prisoners_Chamber_ChamberID",
                        column: x => x.ChamberID,
                        principalTable: "Chamber",
                        principalColumn: "ChamberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisoners_Crime_CrimeID",
                        column: x => x.CrimeID,
                        principalTable: "Crime",
                        principalColumn: "CrimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisoners_Punishment_PunishmentID",
                        column: x => x.PunishmentID,
                        principalTable: "Punishment",
                        principalColumn: "PunishmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    VisitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonerID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<int>(type: "int", nullable: false),
                    VisitingStatus = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    relation_to_the_prisoner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.VisitID);
                    table.ForeignKey(
                        name: "FK_Visit_Prisoners_PrisonerID",
                        column: x => x.PrisonerID,
                        principalTable: "Prisoners",
                        principalColumn: "PrisonerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonalNumber = table.Column<int>(type: "int", nullable: false),
                    TelephoneNumber = table.Column<int>(type: "int", nullable: false),
                    relation_to_the_prisoner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorID);
                    table.ForeignKey(
                        name: "FK_Visitors_Visit_VisitID",
                        column: x => x.VisitID,
                        principalTable: "Visit",
                        principalColumn: "VisitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Block_PrisonID",
                table: "Block",
                column: "PrisonID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_PrisonID",
                table: "Building",
                column: "PrisonID");

            migrationBuilder.CreateIndex(
                name: "IX_Chamber_BlockID",
                table: "Chamber",
                column: "BlockID");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_PrisonID",
                table: "Guards",
                column: "PrisonID");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_ChamberID",
                table: "Prisoners",
                column: "ChamberID");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_CrimeID",
                table: "Prisoners",
                column: "CrimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_PunishmentID",
                table: "Prisoners",
                column: "PunishmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_VisitID",
                table: "Prisoners",
                column: "VisitID");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_VisitorsID",
                table: "Prisoners",
                column: "VisitorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_GuardsID",
                table: "Shift",
                column: "GuardsID");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PrisonerID",
                table: "Visit",
                column: "PrisonerID");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_VisitID",
                table: "Visitors",
                column: "VisitID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prisoners_Visit_VisitID",
                table: "Prisoners",
                column: "VisitID",
                principalTable: "Visit",
                principalColumn: "VisitID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prisoners_Visitors_VisitorsID",
                table: "Prisoners",
                column: "VisitorsID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Block_Prison_PrisonID",
                table: "Block");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamber_Block_BlockID",
                table: "Chamber");

            migrationBuilder.DropForeignKey(
                name: "FK_Prisoners_Chamber_ChamberID",
                table: "Prisoners");

            migrationBuilder.DropForeignKey(
                name: "FK_Prisoners_Crime_CrimeID",
                table: "Prisoners");

            migrationBuilder.DropForeignKey(
                name: "FK_Prisoners_Punishment_PunishmentID",
                table: "Prisoners");

            migrationBuilder.DropForeignKey(
                name: "FK_Prisoners_Visit_VisitID",
                table: "Prisoners");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_Visit_VisitID",
                table: "Visitors");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Guards");

            migrationBuilder.DropTable(
                name: "Prison");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Chamber");

            migrationBuilder.DropTable(
                name: "Crime");

            migrationBuilder.DropTable(
                name: "Punishment");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Prisoners");

            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
