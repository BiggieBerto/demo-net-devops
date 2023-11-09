using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExtraArtsen2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("148ba764-8705-4202-9500-ea1fab6d6264"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("3f332d44-b7ab-4952-8bac-dcb9a62d1422"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("5e048213-4bf4-408c-9877-671e79e77862"), "Artsnaam5", "Artsvoornaam5" },
                    { new Guid("666a67b3-bafa-4596-8b44-f4837a1ade38"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("982c426a-6383-4a82-921d-0c46286357a6"), "Artsnaam", "Artsachternaam" },
                    { new Guid("c1f8bab8-4e67-46f0-b5d3-89987020fbae"), "Artsnaam4", "Artsvoornaam4" },
                    { new Guid("dda7adb6-6110-441a-905f-ec3992aa3696"), "Artsnaam3", "Artsvoornaam3" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("84de97d1-6a71-4a2e-bbd7-521fc8adc010"), "beschrijving 1", "oogziekte 1" },
                    { new Guid("e194103f-504c-4cf4-a50d-898e7978b59d"), "beschrijving 2", "oogziekte 2" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("eb39352f-38c0-4b99-9ef9-b74239473a02"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("0f2d2930-b019-483f-9c89-f3a3f02bcead"), new Guid("dda7adb6-6110-441a-905f-ec3992aa3696"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("2114690d-fa1c-4f28-b6f3-639f42eb8c78"), new Guid("c1f8bab8-4e67-46f0-b5d3-89987020fbae"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("9c534d42-0bb0-4f21-85ad-04afc0619713"), new Guid("982c426a-6383-4a82-921d-0c46286357a6"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("c0d938ef-30b4-4b20-80a9-55852099fdfe"), new Guid("148ba764-8705-4202-9500-ea1fab6d6264"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("dd88c8f5-727e-4f73-9128-ca5f61ab1235"), new Guid("5e048213-4bf4-408c-9877-671e79e77862"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("1b253c38-bd52-4a0d-bc0f-2278334aec2b"), new DateTime(2002, 10, 31, 13, 51, 55, 732, DateTimeKind.Local).AddTicks(4057), new Guid("3f332d44-b7ab-4952-8bac-dcb9a62d1422"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("6b1989ab-0bb7-4b4c-8ae6-f4b5d8023056"), new Guid("666a67b3-bafa-4596-8b44-f4837a1ade38") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("9c534d42-0bb0-4f21-85ad-04afc0619713"), new Guid("eb39352f-38c0-4b99-9ef9-b74239473a02") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("9c534d42-0bb0-4f21-85ad-04afc0619713"), new Guid("eb39352f-38c0-4b99-9ef9-b74239473a02") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("0f2d2930-b019-483f-9c89-f3a3f02bcead"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("2114690d-fa1c-4f28-b6f3-639f42eb8c78"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("c0d938ef-30b4-4b20-80a9-55852099fdfe"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("dd88c8f5-727e-4f73-9128-ca5f61ab1235"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("84de97d1-6a71-4a2e-bbd7-521fc8adc010"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("e194103f-504c-4cf4-a50d-898e7978b59d"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("1b253c38-bd52-4a0d-bc0f-2278334aec2b"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("6b1989ab-0bb7-4b4c-8ae6-f4b5d8023056"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("9c534d42-0bb0-4f21-85ad-04afc0619713"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("148ba764-8705-4202-9500-ea1fab6d6264"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("3f332d44-b7ab-4952-8bac-dcb9a62d1422"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5e048213-4bf4-408c-9877-671e79e77862"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("666a67b3-bafa-4596-8b44-f4837a1ade38"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("c1f8bab8-4e67-46f0-b5d3-89987020fbae"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("dda7adb6-6110-441a-905f-ec3992aa3696"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("eb39352f-38c0-4b99-9ef9-b74239473a02"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("982c426a-6383-4a82-921d-0c46286357a6"));

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
    }
}
