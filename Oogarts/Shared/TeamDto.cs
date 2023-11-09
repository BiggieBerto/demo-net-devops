using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TeamDto
{
    public string Naam { get; set; }
    public string Voornaam { get; set; }
    public string ProfilePicture { get; set; }
    public List<SpecialisatieDto> SpecialisatieDtos { get; set; } = new();
}

