namespace Oogarts.Server.Models
{
    public class Afspraak
    {
        public Guid Id { get; set; }
        public DateTime Datum { get; set; }
        public string ExtraInfo { get;set; }
        
        public Guid PatientId { get;set; }
        public Patient Patient { get;set; }
        public Guid ArtsId { get; set; }
        public Arts Arts { get; set; }
    }
}
