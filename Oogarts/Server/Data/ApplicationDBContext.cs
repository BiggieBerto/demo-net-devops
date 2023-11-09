using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Oogarts.Server.Models;

namespace Oogarts.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Oogziekte> Oogziektes { get; set; }
        public DbSet<Secretariaat> Secretatiaten { get; set; }
        public DbSet<Arts> Artsen { get; set; }
        public DbSet<Patient> Patienten { get; set; }
        public DbSet<Afspraak> Afspraken { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Artikel> Artikels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Gebruiker relaties
            modelBuilder.Entity<Gebruiker>()
                .HasOne(e => e.Arts)
                .WithOne(e => e.Gebruiker)
                .HasForeignKey<Arts>(e => e.GebruikerId)
                .IsRequired();
            modelBuilder.Entity<Gebruiker>()
                .HasOne(e => e.Patient)
                .WithOne(e => e.Gebruiker)
                .HasForeignKey<Patient>(e => e.GebruikerId)
                .IsRequired();
            modelBuilder.Entity<Gebruiker>()
                .HasOne(e => e.Secretariaat)
                .WithOne(e => e.Gebruiker)
                .HasForeignKey<Secretariaat>(e => e.GebruikerId)
                .IsRequired();

            // Afspraak relaties
            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Afspraken)
                .WithOne(e => e.Patient)
                .HasForeignKey(e => e.PatientId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Arts>()
                .HasMany(e => e.Afspraken)
                .WithOne(e => e.Arts)
                .HasForeignKey(e => e.PatientId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            // Specialisatie relaties
            string artsSpecialisatie = "ArtsSpecialisatie";

            modelBuilder.Entity<Arts>()
                .HasMany(e => e.Specialisaties)
                .WithMany(e => e.Artsen)
                .UsingEntity(
                    artsSpecialisatie,
                    l => l.HasOne(typeof(Specialisatie)).WithMany().HasForeignKey("SpecialisatiesId").HasPrincipalKey(nameof(Specialisatie.Id)),
                    r => r.HasOne(typeof(Arts)).WithMany().HasForeignKey("ArtsenId").HasPrincipalKey(nameof(Arts.Id)),
                    j => j.HasKey("ArtsenId", "SpecialisatiesId"));

            // Oogziektes
            modelBuilder.Entity<Oogziekte>().HasData(
                new Oogziekte
                {
                    Id = Guid.NewGuid(),
                    Titel = "oogziekte 1",
                    Beschrijving = "beschrijving 1"
                },
                new Oogziekte
                {
                    Id = Guid.NewGuid(),
                    Titel = "oogziekte 2",
                    Beschrijving = "beschrijving 2"
                }
            );

            // Gebruikers
            var gebruikerArtsId = Guid.NewGuid();
            var gebruikerArtsId2 = Guid.NewGuid();
            var gebruikerArtsId3 = Guid.NewGuid();
            var gebruikerArtsId4 = Guid.NewGuid();
            var gebruikerArtsId5 = Guid.NewGuid();
            var gebruikerSecretariaatId = Guid.NewGuid();
            var gebruikerPatientId = Guid.NewGuid();

            modelBuilder.Entity<Gebruiker>().HasData(new Gebruiker
            {
                Id = gebruikerArtsId,
                Naam = "Artsnaam",
                Voornaam = "Artsachternaam"
            }, new Gebruiker
            {
                Id = gebruikerArtsId2,
                Naam = "Artsnaam2",
                Voornaam = "Artsvoornaam2"
            }, new Gebruiker
            {
                Id = gebruikerArtsId3,
                Naam = "Artsnaam3",
                Voornaam = "Artsvoornaam3"
            }, new Gebruiker
            {
                Id = gebruikerArtsId4,
                Naam = "Artsnaam4",
                Voornaam = "Artsvoornaam4"
            }, new Gebruiker
            {
                Id = gebruikerArtsId5,
                Naam = "Artsnaam5",
                Voornaam = "Artsvoornaam5"
            }, new Gebruiker
            {
                Id = gebruikerSecretariaatId,
                Naam = "Secretatiaatvoornaam",
                Voornaam = "Secretatiaatachternaam"
            }, new Gebruiker
            {
                Id = gebruikerPatientId,
                Naam = "Patientvoornaam",
                Voornaam = "Patientachternaam"
            });

            var artsId = Guid.NewGuid();
            var specialisatieId = Guid.NewGuid();

            modelBuilder.Entity<Specialisatie>().HasData(new Specialisatie
                {
                    Id = specialisatieId,
                    Naam = "Specialisatie 1"
                });

            // Artsen
            modelBuilder.Entity<Arts>().HasData(new Arts
            {
                Id = artsId,
                GebruikerId = gebruikerArtsId,
                ProfilePicture = "img/arts.png",
            }, 
            new Arts
            {
                Id = Guid.NewGuid(),
                GebruikerId = gebruikerArtsId2,
                ProfilePicture = "img/arts.png",
            },
            new Arts
            {
                Id = Guid.NewGuid(),
                GebruikerId = gebruikerArtsId3,
                ProfilePicture = "img/arts.png",
            }, 
            new Arts
            {
                Id = Guid.NewGuid(),
                GebruikerId = gebruikerArtsId4,
                ProfilePicture = "img/arts.png",
            },
            new Arts
            {
                Id = Guid.NewGuid(),
                GebruikerId = gebruikerArtsId5,
                ProfilePicture = "img/arts.png",
            });

            // ArtsSpecialisatie
            modelBuilder.Entity(artsSpecialisatie).HasData(new
            {
                SpecialisatiesId = specialisatieId,
                ArtsenId = artsId
            });

            // Secretatiaat
            modelBuilder.Entity<Secretariaat>().HasData(new Secretariaat
            {
                Id = Guid.NewGuid(),
                GebruikerId = gebruikerSecretariaatId,
                ProfilePicture = "img/secretatiaat.png"
            });

            //// Patienten
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = Guid.NewGuid(),
                Stad = "Gent",
                Postcode = 9000,
                Huisnummer = 12,
                Straat = "Langestraat",
                GeboorteDatum = DateTime.Now.AddDays(-365 * 21),
                GebruikerId = gebruikerPatientId
            });
            ///Artikels
            modelBuilder.Entity<Artikel>().HasData(new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "lorem ipsum",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "Artikel 2",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            }, new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "Artikel 3",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 4",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 5",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 6",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 7",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 8",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 9",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            },new Artikel
            {
                Id = Guid.NewGuid(),
                Titel = "artikel 10",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam rutrum aliquam nisl, vitae dignissim nisl. Pellentesque ante risus, tempus at tortor a, convallis auctor mi. Curabitur sed venenatis turpis. Integer rhoncus diam id diam tempor ornare. Vivamus fringilla consequat ligula, et rutrum odio imperdiet ut. Praesent facilisis accumsan felis nec interdum. Phasellus eget placerat mauris. Phasellus vel imperdiet turpis. Fusce rutrum elementum mi at elementum. Donec ante ligula, vulputate ut molestie a, posuere eget lacus. Quisque rutrum arcu lacus.\n\n",
                Image = "https://smb.ibsrv.net/imageresizer/image/article_manager/1200x1200/128017/609687/heroimage0.674794001653513256.jpg"
            }
            );

        }
    }
}
