using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("81ed85e6-7cd8-4c42-b5d5-e3b855f40792"), new Guid("11826d74-04f6-4815-928f-e59f9cef050d") });

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("7bb3b28c-acda-497a-9734-00a293d8a01b"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("97501ddd-28d6-4ce0-936b-68d9cb23bb53"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("ef35cf6d-1dd3-466c-9b10-607f3694ef4b"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("853bd3e4-4b72-45da-ab1d-92354175c2a9"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("81ed85e6-7cd8-4c42-b5d5-e3b855f40792"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5cc29eab-03d3-4333-a546-d12e107debb7"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("a8753721-287b-45e0-89c4-bd10cae23309"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("11826d74-04f6-4815-928f-e59f9cef050d"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("09794712-6ff2-4243-9092-302396200c5b"));

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("2ff2b20e-7347-4385-83b8-89b3005b917e"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("6c8b60a9-e27b-4842-b157-71207b2b9e2e"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("cc13db99-4f6f-4ca4-bfbf-fbf49cfdb254"), "Artsnaam", "Artsachternaam" },
                    { new Guid("cd9c2195-cbe8-4a18-bbb7-fee07e874360"), "Secretatiaatvoornaam", "Secretatiaatachternaam" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("13fc30f2-378c-423d-a9b8-a3ddca6ed3f3"), "beschrijving 1", "oogziekte 1" },
                    { new Guid("9cf5f3be-239e-47c9-a828-7f5fc2f467ec"), "beschrijving 2", "oogziekte 2" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("bc63eebb-4f42-47d6-afa2-ef577dc77b97"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("472b56ce-0e12-479b-9119-716da33a7ec9"), new Guid("cc13db99-4f6f-4ca4-bfbf-fbf49cfdb254"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("6365d4b7-5920-4536-88a5-e85cd3c63e9d"), new Guid("2ff2b20e-7347-4385-83b8-89b3005b917e"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("de1e4e32-cdb3-440a-8999-8435cad0b0c4"), new DateTime(2002, 10, 24, 16, 16, 50, 268, DateTimeKind.Local).AddTicks(3936), new Guid("6c8b60a9-e27b-4842-b157-71207b2b9e2e"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("25c30044-bf9f-494b-9df3-951e3f2abf2e"), new Guid("cd9c2195-cbe8-4a18-bbb7-fee07e874360") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("472b56ce-0e12-479b-9119-716da33a7ec9"), new Guid("bc63eebb-4f42-47d6-afa2-ef577dc77b97") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("472b56ce-0e12-479b-9119-716da33a7ec9"), new Guid("bc63eebb-4f42-47d6-afa2-ef577dc77b97") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("6365d4b7-5920-4536-88a5-e85cd3c63e9d"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("13fc30f2-378c-423d-a9b8-a3ddca6ed3f3"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("9cf5f3be-239e-47c9-a828-7f5fc2f467ec"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("de1e4e32-cdb3-440a-8999-8435cad0b0c4"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("25c30044-bf9f-494b-9df3-951e3f2abf2e"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("472b56ce-0e12-479b-9119-716da33a7ec9"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("2ff2b20e-7347-4385-83b8-89b3005b917e"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("6c8b60a9-e27b-4842-b157-71207b2b9e2e"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("cd9c2195-cbe8-4a18-bbb7-fee07e874360"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("bc63eebb-4f42-47d6-afa2-ef577dc77b97"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("cc13db99-4f6f-4ca4-bfbf-fbf49cfdb254"));

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
        }
    }
}
