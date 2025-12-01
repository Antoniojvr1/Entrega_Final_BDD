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
    public class TipoDonantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoDonantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoDonantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDonante>>> GetTiposDonante()
        {
            return await _context.TiposDonante.ToListAsync();
        }

        // GET: api/TipoDonantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoDonante>> GetTipoDonante(int id)
        {
            var tipoDonante = await _context.TiposDonante.FindAsync(id);

            if (tipoDonante == null)
            {
                return NotFound();
            }

            return tipoDonante;
        }

        // PUT: api/TipoDonantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoDonante(int id, TipoDonante tipoDonante)
        {
            if (id != tipoDonante.idtipo_donante)
            {
                return BadRequest();
            }

            _context.Entry(tipoDonante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDonanteExists(id))
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

        // POST: api/TipoDonantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoDonante>> PostTipoDonante(TipoDonante tipoDonante)
        {
            _context.TiposDonante.Add(tipoDonante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoDonante", new { id = tipoDonante.idtipo_donante }, tipoDonante);
        }

        // DELETE: api/TipoDonantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoDonante(int id)
        {
            var tipoDonante = await _context.TiposDonante.FindAsync(id);
            if (tipoDonante == null)
            {
                return NotFound();
            }

            _context.TiposDonante.Remove(tipoDonante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoDonanteExists(int id)
        {
            return _context.TiposDonante.Any(e => e.idtipo_donante == id);
        }
    }
}
