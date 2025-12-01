using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROYECTO_ONG.Context;
using API_PROYECTO_ONG.Models;

namespace API_PROYECTO_ONG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Proyecto_ONGController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Proyecto_ONGController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Proyecto_ONG
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proyecto_ONG>>> GetProyectosONG()
        {
            return await _context.ProyectosONG.ToListAsync();
        }

        // GET: api/Proyecto_ONG/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proyecto_ONG>> GetProyecto_ONG(int id)
        {
            var proyecto_ONG = await _context.ProyectosONG.FindAsync(id);

            if (proyecto_ONG == null)
            {
                return NotFound();
            }

            return proyecto_ONG;
        }

        // PUT: api/Proyecto_ONG/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyecto_ONG(int id, Proyecto_ONG proyecto_ONG)
        {
            if (id != proyecto_ONG.idproyecto_ONG)
            {
                return BadRequest();
            }

            _context.Entry(proyecto_ONG).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Proyecto_ONGExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Proyecto_ONG
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proyecto_ONG>> PostProyecto_ONG(Proyecto_ONG proyecto_ONG)
        {
            _context.ProyectosONG.Add(proyecto_ONG);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProyecto_ONG", new { id = proyecto_ONG.idproyecto_ONG }, proyecto_ONG);
        }

        // DELETE: api/Proyecto_ONG/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyecto_ONG(int id)
        {
            var proyecto_ONG = await _context.ProyectosONG.FindAsync(id);
            if (proyecto_ONG == null)
            {
                return NotFound();
            }

            _context.ProyectosONG.Remove(proyecto_ONG);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Proyecto_ONGExists(int id)
        {
            return _context.ProyectosONG.Any(e => e.idproyecto_ONG == id);
        }
    }
}
