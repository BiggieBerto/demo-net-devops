﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oogarts.Server.Data;

#nullable disable

namespace Oogarts.Server.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231108221920_ExtraArtikels")]
    partial class ExtraArtikels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArtsSpecialisatie", b =>
                {
                    b.Property<Guid>("ArtsenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SpecialisatiesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArtsenId", "SpecialisatiesId");

                    b.HasIndex("SpecialisatiesId");

                    b.ToTable("ArtsSpecialisatie");

                    b.HasData(
                        new
                        {
                            ArtsenId = new Guid("dcf7f460-3e4b-4d1d-8b2d-edd86180c8b7"),
                            SpecialisatiesId = new Guid("9fb23b64-51d2-4f64-a2d5-a1379d6c6ed5")
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Afspraak", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Afspraken");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Artikel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artikels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e4c082be-4346-4438-b2fb-1de07bd142a3"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "lorem ipsum"
                        },
                        new
                        {
                            Id = new Guid("286c21b3-3ff7-4d88-a320-0a995a77b183"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "Artikel 2"
                        },
                        new
                        {
                            Id = new Guid("5ff46ac7-6f32-41c2-8f46-3fcfc0d510d0"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "Artikel 3"
                        },
                        new
                        {
                            Id = new Guid("2c5aa21a-fffa-4776-a01d-80f3dd52ccf2"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 4"
                        },
                        new
                        {
                            Id = new Guid("ef664d87-fd9b-486d-adf3-cf4c9de16e45"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 5"
                        },
                        new
                        {
                            Id = new Guid("e36910ce-1ea0-4073-a604-d9b75f690be8"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 6"
                        },
                        new
                        {
                            Id = new Guid("81269947-e5a8-42ba-b0fc-84292a09d31f"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 7"
                        },
                        new
                        {
                            Id = new Guid("40357552-99ec-40cb-a34f-d98d698337dc"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 8"
                        },
                        new
                        {
                            Id = new Guid("21b82f14-57be-47ce-b95d-5f21deb7b5a1"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 9"
                        },
                        new
                        {
                            Id = new Guid("cb6ac354-cf3a-4a4d-ae22-ac9b7771e405"),
                            Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                            Titel = "artikel 10"
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Arts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GebruikerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId")
                        .IsUnique();

                    b.ToTable("Artsen");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dcf7f460-3e4b-4d1d-8b2d-edd86180c8b7"),
                            GebruikerId = new Guid("8ef615a7-f390-4de0-834c-2c646c64c416"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("a5b39622-b093-439a-93d8-56f62c37389c"),
                            GebruikerId = new Guid("8e51a60f-dde2-41e5-b44f-ae5785c74835"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("b60ea214-dd12-474f-89ea-643c02e21c74"),
                            GebruikerId = new Guid("737b88a2-735f-4070-8ae6-5324efc534f4"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("02630b98-e88d-41b8-9084-974116870672"),
                            GebruikerId = new Guid("9e95626e-b7ea-43cc-bea7-2c877c741ddc"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("9a3646a4-f3a4-4acc-bc88-ed5dfd3ba881"),
                            GebruikerId = new Guid("5c37ef30-9de9-49eb-8a91-33b27dc1b10f"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Gebruiker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gebruikers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ef615a7-f390-4de0-834c-2c646c64c416"),
                            Naam = "Artsnaam",
                            Voornaam = "Artsachternaam"
                        },
                        new
                        {
                            Id = new Guid("8e51a60f-dde2-41e5-b44f-ae5785c74835"),
                            Naam = "Artsnaam2",
                            Voornaam = "Artsvoornaam2"
                        },
                        new
                        {
                            Id = new Guid("737b88a2-735f-4070-8ae6-5324efc534f4"),
                            Naam = "Artsnaam3",
                            Voornaam = "Artsvoornaam3"
                        },
                        new
                        {
                            Id = new Guid("9e95626e-b7ea-43cc-bea7-2c877c741ddc"),
                            Naam = "Artsnaam4",
                            Voornaam = "Artsvoornaam4"
                        },
                        new
                        {
                            Id = new Guid("5c37ef30-9de9-49eb-8a91-33b27dc1b10f"),
                            Naam = "Artsnaam5",
                            Voornaam = "Artsvoornaam5"
                        },
                        new
                        {
                            Id = new Guid("5e7ebc50-125b-4272-b8a9-a0534f48d5cd"),
                            Naam = "Secretatiaatvoornaam",
                            Voornaam = "Secretatiaatachternaam"
                        },
                        new
                        {
                            Id = new Guid("490476b0-b5d5-4cd5-adaa-864600a1bb1a"),
                            Naam = "Patientvoornaam",
                            Voornaam = "Patientachternaam"
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Oogziekte", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Oogziektes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f3558b21-eec1-44ea-8904-2207bc56a110"),
                            Beschrijving = "beschrijving 1",
                            Titel = "oogziekte 1"
                        },
                        new
                        {
                            Id = new Guid("1e10a697-1b67-4339-a387-8b05ff74f24e"),
                            Beschrijving = "beschrijving 2",
                            Titel = "oogziekte 2"
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GeboorteDatum")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GebruikerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Huisnummer")
                        .HasColumnType("int");

                    b.Property<int>("Postcode")
                        .HasColumnType("int");

                    b.Property<string>("Stad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId")
                        .IsUnique();

                    b.ToTable("Patienten");

                    b.HasData(
                        new
                        {
                            Id = new Guid("974329b2-3a2e-4319-9b37-2f50cf4271bd"),
                            GeboorteDatum = new DateTime(2002, 11, 13, 23, 19, 20, 319, DateTimeKind.Local).AddTicks(9110),
                            GebruikerId = new Guid("490476b0-b5d5-4cd5-adaa-864600a1bb1a"),
                            Huisnummer = 12,
                            Postcode = 9000,
                            Stad = "Gent",
                            Straat = "Langestraat"
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Secretariaat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GebruikerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId")
                        .IsUnique();

                    b.ToTable("Secretatiaten");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac12d08d-ba30-460f-8854-134be0827191"),
                            GebruikerId = new Guid("5e7ebc50-125b-4272-b8a9-a0534f48d5cd")
                        });
                });

            modelBuilder.Entity("Oogarts.Server.Models.Specialisatie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialisatie");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9fb23b64-51d2-4f64-a2d5-a1379d6c6ed5"),
                            Naam = "Specialisatie 1"
                        });
                });

            modelBuilder.Entity("ArtsSpecialisatie", b =>
                {
                    b.HasOne("Oogarts.Server.Models.Arts", null)
                        .WithMany()
                        .HasForeignKey("ArtsenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oogarts.Server.Models.Specialisatie", null)
                        .WithMany()
                        .HasForeignKey("SpecialisatiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Oogarts.Server.Models.Afspraak", b =>
                {
                    b.HasOne("Oogarts.Server.Models.Arts", "Arts")
                        .WithMany("Afspraken")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Oogarts.Server.Models.Patient", "Patient")
                        .WithMany("Afspraken")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Arts");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Arts", b =>
                {
                    b.HasOne("Oogarts.Server.Models.Gebruiker", "Gebruiker")
                        .WithOne("Arts")
                        .HasForeignKey("Oogarts.Server.Models.Arts", "GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruiker");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Patient", b =>
                {
                    b.HasOne("Oogarts.Server.Models.Gebruiker", "Gebruiker")
                        .WithOne("Patient")
                        .HasForeignKey("Oogarts.Server.Models.Patient", "GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruiker");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Secretariaat", b =>
                {
                    b.HasOne("Oogarts.Server.Models.Gebruiker", "Gebruiker")
                        .WithOne("Secretariaat")
                        .HasForeignKey("Oogarts.Server.Models.Secretariaat", "GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruiker");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Arts", b =>
                {
                    b.Navigation("Afspraken");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Gebruiker", b =>
                {
                    b.Navigation("Arts");

                    b.Navigation("Patient");

                    b.Navigation("Secretariaat");
                });

            modelBuilder.Entity("Oogarts.Server.Models.Patient", b =>
                {
                    b.Navigation("Afspraken");
                });
#pragma warning restore 612, 618
        }
    }
}
