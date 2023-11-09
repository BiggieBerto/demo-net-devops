using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class ArtikelsFoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("24d7e0b9-701f-4129-857e-4305bb0d527a"));

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

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Artikels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Artikels",
                columns: new[] { "Id", "Image", "Text", "Titel" },
                values: new object[] { new Guid("e40afa64-7955-42aa-b356-04c354308da4"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor", "lorem ipsum" });

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("16dcbe42-3190-4ec3-acf4-0c1934312a8a"), "Artsnaam4", "Artsvoornaam4" },
                    { new Guid("180ae481-5d6e-4693-97ee-06f8a6b8083b"), "Artsnaam5", "Artsvoornaam5" },
                    { new Guid("2b1d9ed4-6280-43f9-9ce1-b3c7a8c18626"), "Artsnaam", "Artsachternaam" },
                    { new Guid("5ac100ca-716f-40e4-b990-0805f7093bd6"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("5e5776e8-6de8-472d-9b7f-a1335e5405a0"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("844ebb1c-d89b-4eb4-9a4c-a9bb95e1e241"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("d6547d4d-821b-481e-9088-82cdc5e8c802"), "Secretatiaatvoornaam", "Secretatiaatachternaam" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("4ad1e879-bf4f-487c-8818-c2ada402953c"), "beschrijving 1", "oogziekte 1" },
                    { new Guid("74acdd50-ad9b-4c7a-a097-51d111d84250"), "beschrijving 2", "oogziekte 2" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("b1813626-bfec-4a1c-a0e9-196d591f5c67"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("3ba667af-e695-483b-b9af-64d819432a01"), new Guid("180ae481-5d6e-4693-97ee-06f8a6b8083b"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("8554f0f0-a778-4072-9b76-b0a5f5ce7c2c"), new Guid("5ac100ca-716f-40e4-b990-0805f7093bd6"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("8860b959-c83c-4daf-b271-2c083be4f272"), new Guid("5e5776e8-6de8-472d-9b7f-a1335e5405a0"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("a632f34a-0335-42b4-8ccd-bd7969e4adc4"), new Guid("2b1d9ed4-6280-43f9-9ce1-b3c7a8c18626"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("dee43535-6929-473d-992c-f078ad09b93b"), new Guid("16dcbe42-3190-4ec3-acf4-0c1934312a8a"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("5b5c3cdf-2173-4479-9572-f07a0425ad42"), new DateTime(2002, 11, 7, 20, 9, 53, 933, DateTimeKind.Local).AddTicks(8940), new Guid("844ebb1c-d89b-4eb4-9a4c-a9bb95e1e241"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("359367a3-f31d-4ea9-9a72-625e51b92690"), new Guid("d6547d4d-821b-481e-9088-82cdc5e8c802") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("a632f34a-0335-42b4-8ccd-bd7969e4adc4"), new Guid("b1813626-bfec-4a1c-a0e9-196d591f5c67") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("e40afa64-7955-42aa-b356-04c354308da4"));

            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("a632f34a-0335-42b4-8ccd-bd7969e4adc4"), new Guid("b1813626-bfec-4a1c-a0e9-196d591f5c67") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("3ba667af-e695-483b-b9af-64d819432a01"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("8554f0f0-a778-4072-9b76-b0a5f5ce7c2c"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("8860b959-c83c-4daf-b271-2c083be4f272"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("dee43535-6929-473d-992c-f078ad09b93b"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("4ad1e879-bf4f-487c-8818-c2ada402953c"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("74acdd50-ad9b-4c7a-a097-51d111d84250"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("5b5c3cdf-2173-4479-9572-f07a0425ad42"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("359367a3-f31d-4ea9-9a72-625e51b92690"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("a632f34a-0335-42b4-8ccd-bd7969e4adc4"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("16dcbe42-3190-4ec3-acf4-0c1934312a8a"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("180ae481-5d6e-4693-97ee-06f8a6b8083b"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5ac100ca-716f-40e4-b990-0805f7093bd6"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5e5776e8-6de8-472d-9b7f-a1335e5405a0"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("844ebb1c-d89b-4eb4-9a4c-a9bb95e1e241"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("d6547d4d-821b-481e-9088-82cdc5e8c802"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("b1813626-bfec-4a1c-a0e9-196d591f5c67"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("2b1d9ed4-6280-43f9-9ce1-b3c7a8c18626"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Artikels");

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
    }
}
