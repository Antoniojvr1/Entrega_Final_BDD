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
    public class PresupuestoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PresupuestoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Presupuestoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Presupuesto>>> GetPresupuestos()
        {
            return await _context.Presupuestos.ToListAsync();
        }

        // GET: api/Presupuestoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Presupuesto>> GetPresupuesto(int id)
        {
            var presupuesto = await _context.Presupuestos.FindAsync(id);

            if (presupuesto == null)
            {
                return NotFound();
            }

            return presupuesto;
        }

        // PUT: api/Presupuestoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPresupuesto(int id, Presupuesto presupuesto)
        {
            if (id != presupuesto.idpresupuesto)
            {
                return BadRequest();
            }

            _context.Entry(presupuesto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PresupuestoExists(id))
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

        // POST: api/Presupuestoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Presupuesto>> PostPresupuesto(Presupuesto presupuesto)
        {
            _context.Presupuestos.Add(presupuesto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPresupuesto", new { id = presupuesto.idpresupuesto }, presupuesto);
        }

        // DELETE: api/Presupuestoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePresupuesto(int id)
        {
            var presupuesto = await _context.Presupuestos.FindAsync(id);
            if (presupuesto == null)
            {
                return NotFound();
            }

            _context.Presupuestos.Remove(presupuesto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PresupuestoExists(int id)
        {
            return _context.Presupuestos.Any(e => e.idpresupuesto == id);
        }
    }
}
