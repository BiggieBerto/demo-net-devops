using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oogarts.Server.Data;

namespace Oogarts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public TeamController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<TeamDto>> Get()
        {
            var gebruikers = await _context
                .Gebruikers
                .Include(x => x.Secretariaat)
                .Include(x => x.Arts)
                .ThenInclude(x => x.Specialisaties)
                .Where(x => x.Arts != null || x.Secretariaat != null)
                .ToListAsync();

            return Ok(gebruikers.Select(gebruiker => new TeamDto
            {
                Naam = gebruiker.Naam,
                Voornaam = gebruiker.Voornaam,
                SpecialisatieDtos = gebruiker.Arts != null ? gebruiker.Arts.Specialisaties.Select(x => new SpecialisatieDto
                {
                    Naam = x.Naam
                }).ToList() : new (),
                ProfilePicture = gebruiker.Arts != null ? gebruiker.Arts.ProfilePicture : gebruiker.Secretariaat.ProfilePicture
            }));
        }
    }
}
