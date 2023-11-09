namespace Oogarts.Server.Models
{
    public class Specialisatie
    {
        public Guid Id { get; set; }
        public string Naam { get; set; }
        public List<Arts> Artsen { get; } = new();
    }
}
