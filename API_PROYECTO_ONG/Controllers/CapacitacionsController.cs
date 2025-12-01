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
    public class CapacitacionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CapacitacionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Capacitacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Capacitacion>>> GetCapacitaciones()
        {
            return await _context.Capacitaciones.ToListAsync();
        }

        // GET: api/Capacitacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Capacitacion>> GetCapacitacion(int id)
        {
            var capacitacion = await _context.Capacitaciones.FindAsync(id);

            if (capacitacion == null)
            {
                return NotFound();
            }

            return capacitacion;
        }

        // PUT: api/Capacitacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCapacitacion(int id, Capacitacion capacitacion)
        {
            if (id != capacitacion.idcapacitacion)
            {
                return BadRequest();
            }

            _context.Entry(capacitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapacitacionExists(id))
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

        // POST: api/Capacitacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Capacitacion>> PostCapacitacion(Capacitacion capacitacion)
        {
            _context.Capacitaciones.Add(capacitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCapacitacion", new { id = capacitacion.idcapacitacion }, capacitacion);
        }

        // DELETE: api/Capacitacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCapacitacion(int id)
        {
            var capacitacion = await _context.Capacitaciones.FindAsync(id);
            if (capacitacion == null)
            {
                return NotFound();
            }

            _context.Capacitaciones.Remove(capacitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CapacitacionExists(int id)
        {
            return _context.Capacitaciones.Any(e => e.idcapacitacion == id);
        }
    }
}
