namespace Oogarts.Server.Models
{
    public class Secretariaat
    {
        public Guid Id { get; set; }
        public Guid GebruikerId { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public string ProfilePicture { get; set; }
    }
}
