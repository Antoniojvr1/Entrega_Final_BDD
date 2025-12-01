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
    public class VoluntariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VoluntariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Voluntarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voluntario>>> GetVoluntarios()
        {
            return await _context.Voluntarios.ToListAsync();
        }

        // GET: api/Voluntarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Voluntario>> GetVoluntario(int id)
        {
            var voluntario = await _context.Voluntarios.FindAsync(id);

            if (voluntario == null)
            {
                return NotFound();
            }

            return voluntario;
        }

        // PUT: api/Voluntarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoluntario(int id, Voluntario voluntario)
        {
            if (id != voluntario.idvoluntario)
            {
                return BadRequest();
            }

            _context.Entry(voluntario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoluntarioExists(id))
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

        // POST: api/Voluntarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Voluntario>> PostVoluntario(Voluntario voluntario)
        {
            _context.Voluntarios.Add(voluntario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoluntario", new { id = voluntario.idvoluntario }, voluntario);
        }

        // DELETE: api/Voluntarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoluntario(int id)
        {
            var voluntario = await _context.Voluntarios.FindAsync(id);
            if (voluntario == null)
            {
                return NotFound();
            }

            _context.Voluntarios.Remove(voluntario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VoluntarioExists(int id)
        {
            return _context.Voluntarios.Any(e => e.idvoluntario == id);
        }
    }
}
