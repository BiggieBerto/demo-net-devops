using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class CorrectProfilePictureSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("02183ef7-cbc2-4bc3-b98d-b60475af639c"), new Guid("9b188154-4fe0-4d4e-aba1-ea21b03eb902") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("c9c4fbb1-adaf-4cbd-b00f-2093f8ff93cb"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("d0814652-5224-4fa7-a81c-5d004ab0cc2e"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("da2ca3d3-2483-48cf-8df1-f48cea13d1fe"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("ddae5497-378d-4bf7-adc7-81397f9191fc"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("3d344201-bdfb-42f0-ba86-07c3f0a52cb6"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("b1af1f3d-16ce-4565-81b7-60b55caf01ba"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("317da0ec-f4a8-4479-b955-d2a6a8075631"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("61468136-9d73-4018-9bb5-c268e05576b9"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("02183ef7-cbc2-4bc3-b98d-b60475af639c"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("57b991ee-da01-4b31-95af-39264c2eed54"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("6c81524f-7996-4076-88d5-87eeea6915a8"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("d87ff090-3927-4d4d-a706-27671cd6baf7"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("e689c0cb-0c1a-4e56-8175-a4a87826b16c"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("efab1d10-b276-4aa7-92dc-65149ff272fa"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("fa149b34-63a5-47ee-b259-e53aaac55c08"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("9b188154-4fe0-4d4e-aba1-ea21b03eb902"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("1923d970-b04c-44e7-9a87-b85555451930"));

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("16db267a-ddef-4466-a531-c856788ab5d8"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("4745d39b-5b45-4255-b142-ea9d5aad5afe"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("5e6d3a96-65cb-45e7-ae61-af22f1bad4bf"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("971b17b8-1f91-41d0-9307-63d7e2c62a9c"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("b6498338-b7e4-488c-ba6c-60f0f5c9afb0"), "Artsnaam", "Artsachternaam" },
                    { new Guid("f604c4eb-6797-4b9e-81f8-49651bcdbca4"), "Artsnaam4", "Artsvoornaam4" },
                    { new Guid("f9e83a2c-b4c3-4ad9-875e-9f419c20ced6"), "Artsnaam5", "Artsvoornaam5" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("93536244-c373-4442-920f-c29cf6af1144"), "beschrijving 2", "oogziekte 2" },
                    { new Guid("9717f883-ebc5-4eba-9c50-e11beddda7b6"), "beschrijving 1", "oogziekte 1" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("2077132a-131b-4e2d-91b7-6b7517a4eb31"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("29af1fc5-f61a-497a-9d8c-609aeabb6a42"), new Guid("f9e83a2c-b4c3-4ad9-875e-9f419c20ced6"), "img/arts.png" },
                    { new Guid("683930b8-1735-4b11-a1a9-75f94e75fbe3"), new Guid("16db267a-ddef-4466-a531-c856788ab5d8"), "img/arts.png" },
                    { new Guid("765f7ea8-3b1f-4599-8ce7-cd9b4e12778e"), new Guid("f604c4eb-6797-4b9e-81f8-49651bcdbca4"), "img/arts.png" },
                    { new Guid("ac18a46e-ac62-48e5-a1f0-9168087ebc02"), new Guid("971b17b8-1f91-41d0-9307-63d7e2c62a9c"), "img/arts.png" },
                    { new Guid("eca11ebe-9b41-4358-8a76-f6e6fb098efd"), new Guid("b6498338-b7e4-488c-ba6c-60f0f5c9afb0"), "img/arts.png" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("9904dfc7-91a1-48ad-bbd1-22cc167bf311"), new DateTime(2002, 11, 14, 16, 5, 13, 187, DateTimeKind.Local).AddTicks(768), new Guid("5e6d3a96-65cb-45e7-ae61-af22f1bad4bf"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[] { new Guid("dbaf0500-c447-41b5-847e-f2760ff4a9ce"), new Guid("4745d39b-5b45-4255-b142-ea9d5aad5afe"), "img/secretatiaat.png" });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("eca11ebe-9b41-4358-8a76-f6e6fb098efd"), new Guid("2077132a-131b-4e2d-91b7-6b7517a4eb31") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("eca11ebe-9b41-4358-8a76-f6e6fb098efd"), new Guid("2077132a-131b-4e2d-91b7-6b7517a4eb31") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("29af1fc5-f61a-497a-9d8c-609aeabb6a42"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("683930b8-1735-4b11-a1a9-75f94e75fbe3"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("765f7ea8-3b1f-4599-8ce7-cd9b4e12778e"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("ac18a46e-ac62-48e5-a1f0-9168087ebc02"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("93536244-c373-4442-920f-c29cf6af1144"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("9717f883-ebc5-4eba-9c50-e11beddda7b6"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("9904dfc7-91a1-48ad-bbd1-22cc167bf311"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("dbaf0500-c447-41b5-847e-f2760ff4a9ce"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("eca11ebe-9b41-4358-8a76-f6e6fb098efd"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("16db267a-ddef-4466-a531-c856788ab5d8"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("4745d39b-5b45-4255-b142-ea9d5aad5afe"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5e6d3a96-65cb-45e7-ae61-af22f1bad4bf"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("971b17b8-1f91-41d0-9307-63d7e2c62a9c"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("f604c4eb-6797-4b9e-81f8-49651bcdbca4"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("f9e83a2c-b4c3-4ad9-875e-9f419c20ced6"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("2077132a-131b-4e2d-91b7-6b7517a4eb31"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("b6498338-b7e4-488c-ba6c-60f0f5c9afb0"));

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1923d970-b04c-44e7-9a87-b85555451930"), "Artsnaam", "Artsachternaam" },
                    { new Guid("57b991ee-da01-4b31-95af-39264c2eed54"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("6c81524f-7996-4076-88d5-87eeea6915a8"), "Artsnaam4", "Artsvoornaam4" },
                    { new Guid("d87ff090-3927-4d4d-a706-27671cd6baf7"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("e689c0cb-0c1a-4e56-8175-a4a87826b16c"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("efab1d10-b276-4aa7-92dc-65149ff272fa"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("fa149b34-63a5-47ee-b259-e53aaac55c08"), "Artsnaam5", "Artsvoornaam5" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("3d344201-bdfb-42f0-ba86-07c3f0a52cb6"), "beschrijving 2", "oogziekte 2" },
                    { new Guid("b1af1f3d-16ce-4565-81b7-60b55caf01ba"), "beschrijving 1", "oogziekte 1" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("9b188154-4fe0-4d4e-aba1-ea21b03eb902"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("02183ef7-cbc2-4bc3-b98d-b60475af639c"), new Guid("1923d970-b04c-44e7-9a87-b85555451930"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("c9c4fbb1-adaf-4cbd-b00f-2093f8ff93cb"), new Guid("e689c0cb-0c1a-4e56-8175-a4a87826b16c"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("d0814652-5224-4fa7-a81c-5d004ab0cc2e"), new Guid("d87ff090-3927-4d4d-a706-27671cd6baf7"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("da2ca3d3-2483-48cf-8df1-f48cea13d1fe"), new Guid("fa149b34-63a5-47ee-b259-e53aaac55c08"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("ddae5497-378d-4bf7-adc7-81397f9191fc"), new Guid("6c81524f-7996-4076-88d5-87eeea6915a8"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("317da0ec-f4a8-4479-b955-d2a6a8075631"), new DateTime(2002, 11, 14, 15, 23, 56, 117, DateTimeKind.Local).AddTicks(1120), new Guid("efab1d10-b276-4aa7-92dc-65149ff272fa"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[] { new Guid("61468136-9d73-4018-9bb5-c268e05576b9"), new Guid("57b991ee-da01-4b31-95af-39264c2eed54"), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fnl.springest.be%2Fstudy-online-nl%2Fmbo-medewerker-secretariaat-en-receptie-niveau-2&psig=AOvVaw01YPR2szbNErbmHyU7Flvl&ust=1699626212997000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCNDlupePt4IDFQAAAAAdAAAAABAE" });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("02183ef7-cbc2-4bc3-b98d-b60475af639c"), new Guid("9b188154-4fe0-4d4e-aba1-ea21b03eb902") });
        }
    }
}
