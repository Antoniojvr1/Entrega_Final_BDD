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
    public class VoluntarioCapacitacionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VoluntarioCapacitacionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VoluntarioCapacitacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoluntarioCapacitacion>>> GetVoluntarioCapacitaciones()
        {
            return await _context.VoluntarioCapacitaciones.ToListAsync();
        }

        // GET: api/VoluntarioCapacitacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoluntarioCapacitacion>> GetVoluntarioCapacitacion(int id)
        {
            var voluntarioCapacitacion = await _context.VoluntarioCapacitaciones.FindAsync(id);

            if (voluntarioCapacitacion == null)
            {
                return NotFound();
            }

            return voluntarioCapacitacion;
        }

        // PUT: api/VoluntarioCapacitacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoluntarioCapacitacion(int id, VoluntarioCapacitacion voluntarioCapacitacion)
        {
            if (id != voluntarioCapacitacion.voluntario_idvoluntario)
            {
                return BadRequest();
            }

            _context.Entry(voluntarioCapacitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoluntarioCapacitacionExists(id))
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

        // POST: api/VoluntarioCapacitacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VoluntarioCapacitacion>> PostVoluntarioCapacitacion(VoluntarioCapacitacion voluntarioCapacitacion)
        {
            _context.VoluntarioCapacitaciones.Add(voluntarioCapacitacion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VoluntarioCapacitacionExists(voluntarioCapacitacion.voluntario_idvoluntario))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVoluntarioCapacitacion", new { id = voluntarioCapacitacion.voluntario_idvoluntario }, voluntarioCapacitacion);
        }

        // DELETE: api/VoluntarioCapacitacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoluntarioCapacitacion(int id)
        {
            var voluntarioCapacitacion = await _context.VoluntarioCapacitaciones.FindAsync(id);
            if (voluntarioCapacitacion == null)
            {
                return NotFound();
            }

            _context.VoluntarioCapacitaciones.Remove(voluntarioCapacitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VoluntarioCapacitacionExists(int id)
        {
            return _context.VoluntarioCapacitaciones.Any(e => e.voluntario_idvoluntario == id);
        }
    }
}
