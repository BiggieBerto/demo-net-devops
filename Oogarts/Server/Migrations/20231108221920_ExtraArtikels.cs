using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Oogarts.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExtraArtikels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Artikels",
                columns: new[] { "Id", "Image", "Text", "Titel" },
                values: new object[,]
                {
                    { new Guid("21b82f14-57be-47ce-b95d-5f21deb7b5a1"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 9" },
                    { new Guid("286c21b3-3ff7-4d88-a320-0a995a77b183"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "Artikel 2" },
                    { new Guid("2c5aa21a-fffa-4776-a01d-80f3dd52ccf2"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 4" },
                    { new Guid("40357552-99ec-40cb-a34f-d98d698337dc"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 8" },
                    { new Guid("5ff46ac7-6f32-41c2-8f46-3fcfc0d510d0"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "Artikel 3" },
                    { new Guid("81269947-e5a8-42ba-b0fc-84292a09d31f"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 7" },
                    { new Guid("cb6ac354-cf3a-4a4d-ae22-ac9b7771e405"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 10" },
                    { new Guid("e36910ce-1ea0-4073-a604-d9b75f690be8"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 6" },
                    { new Guid("e4c082be-4346-4438-b2fb-1de07bd142a3"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "lorem ipsum" },
                    { new Guid("ef664d87-fd9b-486d-adf3-cf4c9de16e45"), "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n", "artikel 5" }
                });

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("490476b0-b5d5-4cd5-adaa-864600a1bb1a"), "Patientvoornaam", "Patientachternaam" },
                    { new Guid("5c37ef30-9de9-49eb-8a91-33b27dc1b10f"), "Artsnaam5", "Artsvoornaam5" },
                    { new Guid("5e7ebc50-125b-4272-b8a9-a0534f48d5cd"), "Secretatiaatvoornaam", "Secretatiaatachternaam" },
                    { new Guid("737b88a2-735f-4070-8ae6-5324efc534f4"), "Artsnaam3", "Artsvoornaam3" },
                    { new Guid("8e51a60f-dde2-41e5-b44f-ae5785c74835"), "Artsnaam2", "Artsvoornaam2" },
                    { new Guid("8ef615a7-f390-4de0-834c-2c646c64c416"), "Artsnaam", "Artsachternaam" },
                    { new Guid("9e95626e-b7ea-43cc-bea7-2c877c741ddc"), "Artsnaam4", "Artsvoornaam4" }
                });

            migrationBuilder.InsertData(
                table: "Oogziektes",
                columns: new[] { "Id", "Beschrijving", "Titel" },
                values: new object[,]
                {
                    { new Guid("1e10a697-1b67-4339-a387-8b05ff74f24e"), "beschrijving 2", "oogziekte 2" },
                    { new Guid("f3558b21-eec1-44ea-8904-2207bc56a110"), "beschrijving 1", "oogziekte 1" }
                });

            migrationBuilder.InsertData(
                table: "Specialisatie",
                columns: new[] { "Id", "Naam" },
                values: new object[] { new Guid("9fb23b64-51d2-4f64-a2d5-a1379d6c6ed5"), "Specialisatie 1" });

            migrationBuilder.InsertData(
                table: "Artsen",
                columns: new[] { "Id", "GebruikerId", "ProfilePicture" },
                values: new object[,]
                {
                    { new Guid("02630b98-e88d-41b8-9084-974116870672"), new Guid("9e95626e-b7ea-43cc-bea7-2c877c741ddc"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("9a3646a4-f3a4-4acc-bc88-ed5dfd3ba881"), new Guid("5c37ef30-9de9-49eb-8a91-33b27dc1b10f"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("a5b39622-b093-439a-93d8-56f62c37389c"), new Guid("8e51a60f-dde2-41e5-b44f-ae5785c74835"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("b60ea214-dd12-474f-89ea-643c02e21c74"), new Guid("737b88a2-735f-4070-8ae6-5324efc534f4"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" },
                    { new Guid("dcf7f460-3e4b-4d1d-8b2d-edd86180c8b7"), new Guid("8ef615a7-f390-4de0-834c-2c646c64c416"), "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY" }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "GeboorteDatum", "GebruikerId", "Huisnummer", "Postcode", "Stad", "Straat" },
                values: new object[] { new Guid("974329b2-3a2e-4319-9b37-2f50cf4271bd"), new DateTime(2002, 11, 13, 23, 19, 20, 319, DateTimeKind.Local).AddTicks(9110), new Guid("490476b0-b5d5-4cd5-adaa-864600a1bb1a"), 12, 9000, "Gent", "Langestraat" });

            migrationBuilder.InsertData(
                table: "Secretatiaten",
                columns: new[] { "Id", "GebruikerId" },
                values: new object[] { new Guid("ac12d08d-ba30-460f-8854-134be0827191"), new Guid("5e7ebc50-125b-4272-b8a9-a0534f48d5cd") });

            migrationBuilder.InsertData(
                table: "ArtsSpecialisatie",
                columns: new[] { "ArtsenId", "SpecialisatiesId" },
                values: new object[] { new Guid("dcf7f460-3e4b-4d1d-8b2d-edd86180c8b7"), new Guid("9fb23b64-51d2-4f64-a2d5-a1379d6c6ed5") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("21b82f14-57be-47ce-b95d-5f21deb7b5a1"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("286c21b3-3ff7-4d88-a320-0a995a77b183"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("2c5aa21a-fffa-4776-a01d-80f3dd52ccf2"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("40357552-99ec-40cb-a34f-d98d698337dc"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("5ff46ac7-6f32-41c2-8f46-3fcfc0d510d0"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("81269947-e5a8-42ba-b0fc-84292a09d31f"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("cb6ac354-cf3a-4a4d-ae22-ac9b7771e405"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("e36910ce-1ea0-4073-a604-d9b75f690be8"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("e4c082be-4346-4438-b2fb-1de07bd142a3"));

            migrationBuilder.DeleteData(
                table: "Artikels",
                keyColumn: "Id",
                keyValue: new Guid("ef664d87-fd9b-486d-adf3-cf4c9de16e45"));

            migrationBuilder.DeleteData(
                table: "ArtsSpecialisatie",
                keyColumns: new[] { "ArtsenId", "SpecialisatiesId" },
                keyValues: new object[] { new Guid("dcf7f460-3e4b-4d1d-8b2d-edd86180c8b7"), new Guid("9fb23b64-51d2-4f64-a2d5-a1379d6c6ed5") });

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("02630b98-e88d-41b8-9084-974116870672"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("9a3646a4-f3a4-4acc-bc88-ed5dfd3ba881"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("a5b39622-b093-439a-93d8-56f62c37389c"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("b60ea214-dd12-474f-89ea-643c02e21c74"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("1e10a697-1b67-4339-a387-8b05ff74f24e"));

            migrationBuilder.DeleteData(
                table: "Oogziektes",
                keyColumn: "Id",
                keyValue: new Guid("f3558b21-eec1-44ea-8904-2207bc56a110"));

            migrationBuilder.DeleteData(
                table: "Patienten",
                keyColumn: "Id",
                keyValue: new Guid("974329b2-3a2e-4319-9b37-2f50cf4271bd"));

            migrationBuilder.DeleteData(
                table: "Secretatiaten",
                keyColumn: "Id",
                keyValue: new Guid("ac12d08d-ba30-460f-8854-134be0827191"));

            migrationBuilder.DeleteData(
                table: "Artsen",
                keyColumn: "Id",
                keyValue: new Guid("dcf7f460-3e4b-4d1d-8b2d-edd86180c8b7"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("490476b0-b5d5-4cd5-adaa-864600a1bb1a"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5c37ef30-9de9-49eb-8a91-33b27dc1b10f"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("5e7ebc50-125b-4272-b8a9-a0534f48d5cd"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("737b88a2-735f-4070-8ae6-5324efc534f4"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("8e51a60f-dde2-41e5-b44f-ae5785c74835"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("9e95626e-b7ea-43cc-bea7-2c877c741ddc"));

            migrationBuilder.DeleteData(
                table: "Specialisatie",
                keyColumn: "Id",
                keyValue: new Guid("9fb23b64-51d2-4f64-a2d5-a1379d6c6ed5"));

            migrationBuilder.DeleteData(
                table: "Gebruikers",
                keyColumn: "Id",
                keyValue: new Guid("8ef615a7-f390-4de0-834c-2c646c64c416"));

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
    }
}
