using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("538938e2-2b7e-4d2c-9607-65709d989a73"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("54d0854c-bcb2-45c2-bae5-26431fe2b88a"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("5fd01c05-709f-4b2f-ab1f-582dd6774291"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("616d2343-31a0-4090-8bf6-57e0db45a12a"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("d9b56e0c-a80d-4216-ad35-817d30da130e"), "Artsnaam", "Artsachternaam" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("5b6fc6ba-5715-4d90-80ad-b85fdd9e46b2"), "beschrijving 1", "oogziekte 1" },
                    { new Guid("cebe0407-5838-4c85-ab87-323bd4e3ed5d"), "beschrijving 2", "oogziekte 2" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("d657a337-8657-4fa6-b23d-d731fa39ca8f"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("60035248-0582-426d-b097-21a2d4c7b423"), new Guid("54d0854c-bcb2-45c2-bae5-26431fe2b88a"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("cdda13ac-8fc8-4f13-83a9-7b4d112ad1dd"), new Guid("538938e2-2b7e-4d2c-9607-65709d989a73"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("dc2259c9-bc34-4f7e-a141-5a2bf0150339"), new Guid("d9b56e0c-a80d-4216-ad35-817d30da130e"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("9826304c-52e8-4bf7-ac6b-7cf95adb1428"), new DateTime(2002, 10, 24, 16, 20, 7, 865, DateTimeKind.Local).AddTicks(6353), new Guid("5fd01c05-709f-4b2f-ab1f-582dd6774291"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("6a27c932-1632-4d5a-b419-669a97f9c116"), new Guid("616d2343-31a0-4090-8bf6-57e0db45a12a") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("dc2259c9-bc34-4f7e-a141-5a2bf0150339"), new Guid("d657a337-8657-4fa6-b23d-d731fa39ca8f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("dc2259c9-bc34-4f7e-a141-5a2bf0150339"), new Guid("d657a337-8657-4fa6-b23d-d731fa39ca8f") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("60035248-0582-426d-b097-21a2d4c7b423"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("cdda13ac-8fc8-4f13-83a9-7b4d112ad1dd"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("5b6fc6ba-5715-4d90-80ad-b85fdd9e46b2"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("cebe0407-5838-4c85-ab87-323bd4e3ed5d"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("9826304c-52e8-4bf7-ac6b-7cf95adb1428"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("6a27c932-1632-4d5a-b419-669a97f9c116"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("dc2259c9-bc34-4f7e-a141-5a2bf0150339"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("538938e2-2b7e-4d2c-9607-65709d989a73"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("54d0854c-bcb2-45c2-bae5-26431fe2b88a"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5fd01c05-709f-4b2f-ab1f-582dd6774291"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("616d2343-31a0-4090-8bf6-57e0db45a12a"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("d657a337-8657-4fa6-b23d-d731fa39ca8f"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("d9b56e0c-a80d-4216-ad35-817d30da130e"));

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
    }
}
