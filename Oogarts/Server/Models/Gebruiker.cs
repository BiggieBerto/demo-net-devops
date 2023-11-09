namespace Oogarts.Server.Models
{
    public class Gebruiker
    {
        public Guid Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam{ get; set; }
        public Secretariaat? Secretariaat { get; set; }
        public Patient? Patient { get; set; }
        public Arts? Arts { get; set; }
    }
}
