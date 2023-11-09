using Microsoft.Extensions.Hosting;

namespace Oogarts.Server.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public Guid GebruikerId { get; set; }
        public Gebruiker Gebruiker { get; set; }

        #region Adres
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public string Stad { get; set; }
        public int Postcode { get; set; }
        #endregion Adres

        public DateTime GeboorteDatum { get; set; }
        public ICollection<Afspraak> Afspraken { get; } = new List<Afspraak>();
    }
}
