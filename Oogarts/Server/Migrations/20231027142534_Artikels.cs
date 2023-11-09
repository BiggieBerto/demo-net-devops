using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class Artikels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Artikels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Artikels",
                columns: new[] { "Id", "Text", "Titel" },
                values: new object[] { new Guid("24d7e0b9-701f-4129-857e-4305bb0d527a"), "Lorem ipsum dolor", "lorem ipsum" });

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("02ab2b88-9725-4b87-84b3-5d7e6bb60796"), "Artsnaam5", "Artsvoornaam5" },
                    { new Guid("191af4af-6e0e-45b8-923c-5a97c9dd38b8"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("58057fea-faa3-4964-b184-9a4c190d6e28"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("5fb85551-116e-46de-8c25-74127c781201"), "Artsnaam", "Artsachternaam" },
                    { new Guid("999ed403-6a0d-48ac-bf6f-8ed381e16e0b"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("da46920e-65ae-4cb5-98a8-88aec01e93ed"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("ff53b112-8399-46d8-91b1-4e7ac7d51d81"), "Artsnaam4", "Artsvoornaam4" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("0e094732-d0cd-425a-ba29-49b82323c8d7"), "beschrijving 2", "oogziekte 2" },
                    { new Guid("2ceef4f0-f4dc-4b13-8db6-3d7e22aeeed4"), "beschrijving 1", "oogziekte 1" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("38198b04-0be7-44c2-bb58-606b989a0d65"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("0a6cadc7-94d9-4a19-b4b4-855748ca77d6"), new Guid("02ab2b88-9725-4b87-84b3-5d7e6bb60796"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("0d7a2610-6811-43fd-869f-162ff1845830"), new Guid("58057fea-faa3-4964-b184-9a4c190d6e28"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("24e36e32-89cc-4944-aabe-79912a72a5b3"), new Guid("5fb85551-116e-46de-8c25-74127c781201"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("2f8ef0eb-10cb-4d61-90fb-4cb966aa4f50"), new Guid("ff53b112-8399-46d8-91b1-4e7ac7d51d81"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("797b3dcf-1234-4013-b0ce-1bb0c152dbdb"), new Guid("da46920e-65ae-4cb5-98a8-88aec01e93ed"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("0f3ad58e-eb4e-4509-827a-292a1b88408b"), new DateTime(2002, 11, 1, 16, 25, 34, 494, DateTimeKind.Local).AddTicks(250), new Guid("999ed403-6a0d-48ac-bf6f-8ed381e16e0b"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("5738e239-cb0f-4464-b5d0-98aedc2abb74"), new Guid("191af4af-6e0e-45b8-923c-5a97c9dd38b8") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("24e36e32-89cc-4944-aabe-79912a72a5b3"), new Guid("38198b04-0be7-44c2-bb58-606b989a0d65") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artikels");

            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("24e36e32-89cc-4944-aabe-79912a72a5b3"), new Guid("38198b04-0be7-44c2-bb58-606b989a0d65") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("0a6cadc7-94d9-4a19-b4b4-855748ca77d6"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("0d7a2610-6811-43fd-869f-162ff1845830"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("2f8ef0eb-10cb-4d61-90fb-4cb966aa4f50"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("797b3dcf-1234-4013-b0ce-1bb0c152dbdb"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("0e094732-d0cd-425a-ba29-49b82323c8d7"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("2ceef4f0-f4dc-4b13-8db6-3d7e22aeeed4"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("0f3ad58e-eb4e-4509-827a-292a1b88408b"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("5738e239-cb0f-4464-b5d0-98aedc2abb74"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("24e36e32-89cc-4944-aabe-79912a72a5b3"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("02ab2b88-9725-4b87-84b3-5d7e6bb60796"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("191af4af-6e0e-45b8-923c-5a97c9dd38b8"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("58057fea-faa3-4964-b184-9a4c190d6e28"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("999ed403-6a0d-48ac-bf6f-8ed381e16e0b"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("da46920e-65ae-4cb5-98a8-88aec01e93ed"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("ff53b112-8399-46d8-91b1-4e7ac7d51d81"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("38198b04-0be7-44c2-bb58-606b989a0d65"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5fb85551-116e-46de-8c25-74127c781201"));

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
    }
}
