using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oogziektes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oogziektes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialisatie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisatie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artsen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GebruikerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artsen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artsen_Gebruikers_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patienten",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GebruikerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Straat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Huisnummer = table.Column<int>(type: "int", nullable: false),
                    Stad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<int>(type: "int", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patienten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patienten_Gebruikers_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Secretatiaten",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GebruikerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretatiaten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secretatiaten_Gebruikers_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtsSpecialisatie",
                columns: table => new
                {
                    ArtsenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialisatiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtsSpecialisatie", x => new { x.ArtsenId, x.SpecialisatiesId });
                    table.ForeignKey(
                        name: "FK_ArtsSpecialisatie_Artsen_ArtsenId",
                        column: x => x.ArtsenId,
                        principalTable: "Artsen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtsSpecialisatie_Specialisatie_SpecialisatiesId",
                        column: x => x.SpecialisatiesId,
                        principalTable: "Specialisatie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Afspraken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afspraken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Afspraken_Artsen_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Artsen",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Afspraken_Patienten_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patienten",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("09794712-6ff2-4243-9092-302396200c5b"), "Artsvoornaam", "Artsachternaam" },
                    { new Guid("5cc29eab-03d3-4333-a546-d12e107debb7"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("a8753721-287b-45e0-89c4-bd10cae23309"), "Patientvoornaam", "Patientachternaam" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("7bb3b28c-acda-497a-9734-00a293d8a01b"), "beschrijving 1", "oogziekte 1" },
                    { new Guid("97501ddd-28d6-4ce0-936b-68d9cb23bb53"), "beschrijving 2", "oogziekte 2" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("11826d74-04f6-4815-928f-e59f9cef050d"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[] { new Guid("81ed85e6-7cd8-4c42-b5d5-e3b855f40792"), new Guid("09794712-6ff2-4243-9092-302396200c5b"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("ef35cf6d-1dd3-466c-9b10-607f3694ef4b"), new DateTime(2002, 10, 24, 16, 6, 3, 781, DateTimeKind.Local).AddTicks(5708), new Guid("a8753721-287b-45e0-89c4-bd10cae23309"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("853bd3e4-4b72-45da-ab1d-92354175c2a9"), new Guid("5cc29eab-03d3-4333-a546-d12e107debb7") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("81ed85e6-7cd8-4c42-b5d5-e3b855f40792"), new Guid("11826d74-04f6-4815-928f-e59f9cef050d") });

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken_PatientId",
                table: "Afspraken",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Artsen_GebruikerId",
                table: "Artsen",
                column: "GebruikerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtsSpecialisatie_SpecialisatiesId",
                table: "ArtsSpecialisatie",
                column: "SpecialisatiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Patienten_GebruikerId",
                table: "Patienten",
                column: "GebruikerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Secretatiaten_GebruikerId",
                table: "Secretatiaten",
                column: "GebruikerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afspraken");

            migrationBuilder.DropTable(
                name: "ArtsSpecialisatie");

            migrationBuilder.DropTable(
                name: "Oogziektes");

            migrationBuilder.DropTable(
                name: "Secretatiaten");

            migrationBuilder.DropTable(
                name: "Patienten");

            migrationBuilder.DropTable(
                name: "Artsen");

            migrationBuilder.DropTable(
                name: "Specialisatie");

            migrationBuilder.DropTable(
                name: "Gebruikers");
        }
    }
}
