using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExtraArtsen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("13c655a6-7015-4468-bebc-51f5e52bd5b3"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("39bd34c7-5647-4e6f-80b7-e94a24831c0a"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("3a230ce2-c499-466a-bd07-6b1d9ae42dbf"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("9c7a3771-8c68-49e8-b0b2-f06a63b05ba0"), "Artsnaam", "Artsachternaam" },
                    { new Guid("9cfb0f29-a25f-40c2-8da9-19c1d48edfa0"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("c2f00842-25b5-4b92-9ab8-3345b1156e1c"), "Artsnaam5", "Artsvoornaam5" },
                    { new Guid("d3b49690-2e93-4e61-a9dd-704f27bc21c4"), "Artsnaam4", "Artsvoornaam4" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("c831929f-d994-401e-be19-0baa4af5b141"), "beschrijving 2", "oogziekte 2" },
                    { new Guid("cc4a1bb3-c29b-4323-bede-dc6dbc585b13"), "beschrijving 1", "oogziekte 1" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("f12b975a-a3a7-4f42-aea6-56370ec2e9ca"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("22c293e3-265b-4795-8437-5a5ae58906de"), new Guid("9cfb0f29-a25f-40c2-8da9-19c1d48edfa0"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("b5df4e82-8246-4d0a-8282-0c75f8504963"), new Guid("3a230ce2-c499-466a-bd07-6b1d9ae42dbf"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("deb6f925-af43-4cfa-9f41-54e4a32d64b9"), new Guid("9c7a3771-8c68-49e8-b0b2-f06a63b05ba0"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("1eb07bb5-a065-43de-b45f-2690478f221f"), new DateTime(2002, 10, 31, 13, 50, 11, 642, DateTimeKind.Local).AddTicks(1854), new Guid("13c655a6-7015-4468-bebc-51f5e52bd5b3"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("333feb88-bacc-46f4-b082-419ad4c90355"), new Guid("39bd34c7-5647-4e6f-80b7-e94a24831c0a") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("deb6f925-af43-4cfa-9f41-54e4a32d64b9"), new Guid("f12b975a-a3a7-4f42-aea6-56370ec2e9ca") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("deb6f925-af43-4cfa-9f41-54e4a32d64b9"), new Guid("f12b975a-a3a7-4f42-aea6-56370ec2e9ca") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("22c293e3-265b-4795-8437-5a5ae58906de"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("b5df4e82-8246-4d0a-8282-0c75f8504963"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("c2f00842-25b5-4b92-9ab8-3345b1156e1c"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("d3b49690-2e93-4e61-a9dd-704f27bc21c4"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("c831929f-d994-401e-be19-0baa4af5b141"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("cc4a1bb3-c29b-4323-bede-dc6dbc585b13"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("1eb07bb5-a065-43de-b45f-2690478f221f"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("333feb88-bacc-46f4-b082-419ad4c90355"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("deb6f925-af43-4cfa-9f41-54e4a32d64b9"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("13c655a6-7015-4468-bebc-51f5e52bd5b3"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("39bd34c7-5647-4e6f-80b7-e94a24831c0a"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("3a230ce2-c499-466a-bd07-6b1d9ae42dbf"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("9cfb0f29-a25f-40c2-8da9-19c1d48edfa0"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("f12b975a-a3a7-4f42-aea6-56370ec2e9ca"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("9c7a3771-8c68-49e8-b0b2-f06a63b05ba0"));

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
    }
}
