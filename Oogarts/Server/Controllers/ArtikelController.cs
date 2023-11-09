using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oogarts.Server.Data;
using Oogarts.Server.Models;

namespace Oogarts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtikelController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ArtikelController(ApplicationDBContext context)
        {
            _context = context;
        }
        //GET: api/Artikel
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var artikels = await _context.Artikels.ToListAsync();

            return Ok(artikels);

        }
        // GET: api/Artikel/id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var artikel = await _context.Artikels.FindAsync(id);

            if (artikel == null)
            {
                return NotFound();
            }

            return Ok(artikel);
        }
        // POST: api/Artikel
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Artikel artikel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Artikels.Add(artikel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = artikel.Id }, artikel);
        }
        // DELETE: api/Artikel/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artikel = await _context.Artikels.FindAsync(id);

            if (artikel == null)
            {
                return NotFound();
            }

            _context.Artikels.Remove(artikel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}