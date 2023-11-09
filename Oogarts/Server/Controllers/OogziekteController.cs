using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oogarts.Server.Data;

namespace Oogarts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OogziekteController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public OogziekteController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var oogziektes = await _context.Oogziektes.ToListAsync();
            return Ok(oogziektes);
        }
    }
}
