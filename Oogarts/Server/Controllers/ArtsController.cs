using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oogarts.Server.Data;

namespace Oogarts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ArtsController(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
