using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_ONG.Context;
using API_PROYECTO_ONG.Models;

namespace API_PROYECTO_ONG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AreasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Areas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Area>>> GetAreas()
        {
            return await _context.Areas
                .Include(a => a.Sede)
                .Include(a => a.Noticias)
                .ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Area>> GetArea(int id)
        {
            var area = await _context.Areas
                .Include(a => a.Sede)
                .Include(a => a.Noticias)
                .FirstOrDefaultAsync(a => a.idarea == id);

            if (area == null)
                return NotFound();

            return area;
        }

        // POST: api/Areas
        [HttpPost]
        public async Task<ActionResult<Area>> PostArea(Area area)
        {
            // Validar sede
            var sede = await _context.Sedes.FindAsync(area.sede_idsede);
            if (sede == null)
                return BadRequest("La sede especificada no existe.");

            _context.Areas.Add(area);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArea), new { id = area.idarea }, area);
        }

        // PUT: api/Areas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArea(int id, Area area)
        {
            if (id != area.idarea)
                return BadRequest("El ID de la URL no coincide con el del objeto.");

            // Validar sede
            var sede = await _context.Sedes.FindAsync(area.sede_idsede);
            if (sede == null)
                return BadRequest("La sede especificada no existe.");

            var originalArea = await _context.Areas.FindAsync(id);
            if (originalArea == null)
                return NotFound();

            // Actualizar campos permitidos
            originalArea.nombre = area.nombre;
            originalArea.descripcion = area.descripcion;
            originalArea.sede_idsede = area.sede_idsede;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Areas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var area = await _context.Areas.FindAsync(id);
            if (area == null)
                return NotFound();

            _context.Areas.Remove(area);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
