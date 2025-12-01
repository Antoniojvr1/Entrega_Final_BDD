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
    public class DonantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DonantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Donantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donante>>> GetDonantes()
        {
            return await _context.Donantes.ToListAsync();
        }

        // GET: api/Donantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donante>> GetDonante(int id)
        {
            var donante = await _context.Donantes.FindAsync(id);

            if (donante == null)
            {
                return NotFound();
            }

            return donante;
        }

        // PUT: api/Donantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonante(int id, Donante donante)
        {
            if (id != donante.iddonante)
            {
                return BadRequest();
            }

            _context.Entry(donante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonanteExists(id))
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

        // POST: api/Donantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Donante>> PostDonante(Donante donante)
        {
            _context.Donantes.Add(donante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonante", new { id = donante.iddonante }, donante);
        }

        // DELETE: api/Donantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonante(int id)
        {
            var donante = await _context.Donantes.FindAsync(id);
            if (donante == null)
            {
                return NotFound();
            }

            _context.Donantes.Remove(donante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonanteExists(int id)
        {
            return _context.Donantes.Any(e => e.iddonante == id);
        }
    }
}
