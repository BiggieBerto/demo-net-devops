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
    [Migration("20231109142356_ProfilePictureSecretariaat")]
    partial class ProfilePictureSecretariaat
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
                            ArtsenId = new Guid("02183ef7-cbc2-4bc3-b98d-b60475af639c"),
                            SpecialisatiesId = new Guid("9b188154-4fe0-4d4e-aba1-ea21b03eb902")
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
                            Id = new Guid("02183ef7-cbc2-4bc3-b98d-b60475af639c"),
                            GebruikerId = new Guid("1923d970-b04c-44e7-9a87-b85555451930"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("c9c4fbb1-adaf-4cbd-b00f-2093f8ff93cb"),
                            GebruikerId = new Guid("e689c0cb-0c1a-4e56-8175-a4a87826b16c"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("d0814652-5224-4fa7-a81c-5d004ab0cc2e"),
                            GebruikerId = new Guid("d87ff090-3927-4d4d-a706-27671cd6baf7"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("ddae5497-378d-4bf7-adc7-81397f9191fc"),
                            GebruikerId = new Guid("6c81524f-7996-4076-88d5-87eeea6915a8"),
                            ProfilePicture = "https://www.isala.nl/media/21457/tyljwm.jpg?center=0.5431%2c0.5117&mode=crop&width=200&height=200&quality=80&token=XzIQb4Q6IY"
                        },
                        new
                        {
                            Id = new Guid("da2ca3d3-2483-48cf-8df1-f48cea13d1fe"),
                            GebruikerId = new Guid("fa149b34-63a5-47ee-b259-e53aaac55c08"),
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
                            Id = new Guid("1923d970-b04c-44e7-9a87-b85555451930"),
                            Naam = "Artsnaam",
                            Voornaam = "Artsachternaam"
                        },
                        new
                        {
                            Id = new Guid("e689c0cb-0c1a-4e56-8175-a4a87826b16c"),
                            Naam = "Artsnaam2",
                            Voornaam = "Artsvoornaam2"
                        },
                        new
                        {
                            Id = new Guid("d87ff090-3927-4d4d-a706-27671cd6baf7"),
                            Naam = "Artsnaam3",
                            Voornaam = "Artsvoornaam3"
                        },
                        new
                        {
                            Id = new Guid("6c81524f-7996-4076-88d5-87eeea6915a8"),
                            Naam = "Artsnaam4",
                            Voornaam = "Artsvoornaam4"
                        },
                        new
                        {
                            Id = new Guid("fa149b34-63a5-47ee-b259-e53aaac55c08"),
                            Naam = "Artsnaam5",
                            Voornaam = "Artsvoornaam5"
                        },
                        new
                        {
                            Id = new Guid("57b991ee-da01-4b31-95af-39264c2eed54"),
                            Naam = "Secretatiaatvoornaam",
                            Voornaam = "Secretatiaatachternaam"
                        },
                        new
                        {
                            Id = new Guid("efab1d10-b276-4aa7-92dc-65149ff272fa"),
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
                            Id = new Guid("b1af1f3d-16ce-4565-81b7-60b55caf01ba"),
                            Beschrijving = "beschrijving 1",
                            Titel = "oogziekte 1"
                        },
                        new
                        {
                            Id = new Guid("3d344201-bdfb-42f0-ba86-07c3f0a52cb6"),
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
                            Id = new Guid("317da0ec-f4a8-4479-b955-d2a6a8075631"),
                            GeboorteDatum = new DateTime(2002, 11, 14, 15, 23, 56, 117, DateTimeKind.Local).AddTicks(1120),
                            GebruikerId = new Guid("efab1d10-b276-4aa7-92dc-65149ff272fa"),
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

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId")
                        .IsUnique();

                    b.ToTable("Secretatiaten");

                    b.HasData(
                        new
                        {
                            Id = new Guid("61468136-9d73-4018-9bb5-c268e05576b9"),
                            GebruikerId = new Guid("57b991ee-da01-4b31-95af-39264c2eed54"),
                            ProfilePicture = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fnl.springest.be%2Fstudy-online-nl%2Fmbo-medewerker-secretariaat-en-receptie-niveau-2&psig=AOvVaw01YPR2szbNErbmHyU7Flvl&ust=1699626212997000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCNDlupePt4IDFQAAAAAdAAAAABAE"
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
                            Id = new Guid("9b188154-4fe0-4d4e-aba1-ea21b03eb902"),
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
