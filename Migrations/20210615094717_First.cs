using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBargainVbEx.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projecten",
                columns: table => new
                {
                    ProjectNaam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    HuidigBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projecten", x => x.ProjectNaam);
                });

            migrationBuilder.CreateTable(
                name: "Vestigingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vestigingen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeelsleden",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VestigingId = table.Column<int>(type: "int", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeelsleden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personeelsleden_Vestigingen_VestigingId",
                        column: x => x.VestigingId,
                        principalTable: "Vestigingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoneelProject",
                columns: table => new
                {
                    PersoneelsledenId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectenProjectNaam = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoneelProject", x => new { x.PersoneelsledenId, x.ProjectenProjectNaam });
                    table.ForeignKey(
                        name: "FK_PersoneelProject_Personeelsleden_PersoneelsledenId",
                        column: x => x.PersoneelsledenId,
                        principalTable: "Personeelsleden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoneelProject_Projecten_ProjectenProjectNaam",
                        column: x => x.ProjectenProjectNaam,
                        principalTable: "Projecten",
                        principalColumn: "ProjectNaam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersoneelProject_ProjectenProjectNaam",
                table: "PersoneelProject",
                column: "ProjectenProjectNaam");

            migrationBuilder.CreateIndex(
                name: "IX_Personeelsleden_VestigingId",
                table: "Personeelsleden",
                column: "VestigingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersoneelProject");

            migrationBuilder.DropTable(
                name: "Personeelsleden");

            migrationBuilder.DropTable(
                name: "Projecten");

            migrationBuilder.DropTable(
                name: "Vestigingen");
        }
    }
}
