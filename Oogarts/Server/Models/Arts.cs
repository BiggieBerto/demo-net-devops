using Microsoft.Extensions.Hosting;

namespace Oogarts.Server.Models
{
    public class Arts
    {
        public Guid Id { get; set; }
        public List<Specialisatie> Specialisaties { get; } = new();
        public ICollection<Afspraak> Afspraken { get; } = new List<Afspraak>();
        
        public Guid GebruikerId { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public string ProfilePicture { get; set; }
    }
}
