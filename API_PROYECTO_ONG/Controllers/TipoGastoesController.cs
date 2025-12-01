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
    public class TipoGastoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoGastoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoGastoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoGasto>>> GetTiposGasto()
        {
            return await _context.TiposGasto.ToListAsync();
        }

        // GET: api/TipoGastoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoGasto>> GetTipoGasto(int id)
        {
            var tipoGasto = await _context.TiposGasto.FindAsync(id);

            if (tipoGasto == null)
            {
                return NotFound();
            }

            return tipoGasto;
        }

        // PUT: api/TipoGastoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoGasto(int id, TipoGasto tipoGasto)
        {
            if (id != tipoGasto.idtipo_gasto)
            {
                return BadRequest();
            }

            _context.Entry(tipoGasto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoGastoExists(id))
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

        // POST: api/TipoGastoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoGasto>> PostTipoGasto(TipoGasto tipoGasto)
        {
            _context.TiposGasto.Add(tipoGasto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoGasto", new { id = tipoGasto.idtipo_gasto }, tipoGasto);
        }

        // DELETE: api/TipoGastoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoGasto(int id)
        {
            var tipoGasto = await _context.TiposGasto.FindAsync(id);
            if (tipoGasto == null)
            {
                return NotFound();
            }

            _context.TiposGasto.Remove(tipoGasto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoGastoExists(int id)
        {
            return _context.TiposGasto.Any(e => e.idtipo_gasto == id);
        }
    }
}
