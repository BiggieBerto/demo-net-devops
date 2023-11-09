using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePictureSecretariaat : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Secretatiaten",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Secretatiaten");

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
