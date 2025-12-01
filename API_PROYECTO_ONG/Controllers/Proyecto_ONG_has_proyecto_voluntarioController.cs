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
    public class Proyecto_ONG_has_proyecto_voluntarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Proyecto_ONG_has_proyecto_voluntarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Proyecto_ONG_has_proyecto_voluntario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proyecto_ONG_has_proyecto_voluntario>>> GetProyectoONGVoluntarios()
        {
            return await _context.ProyectoONGVoluntarios.ToListAsync();
        }

        // GET: api/Proyecto_ONG_has_proyecto_voluntario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proyecto_ONG_has_proyecto_voluntario>> GetProyecto_ONG_has_proyecto_voluntario(int id)
        {
            var proyecto_ONG_has_proyecto_voluntario = await _context.ProyectoONGVoluntarios.FindAsync(id);

            if (proyecto_ONG_has_proyecto_voluntario == null)
            {
                return NotFound();
            }

            return proyecto_ONG_has_proyecto_voluntario;
        }

        // PUT: api/Proyecto_ONG_has_proyecto_voluntario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyecto_ONG_has_proyecto_voluntario(int id, Proyecto_ONG_has_proyecto_voluntario proyecto_ONG_has_proyecto_voluntario)
        {
            if (id != proyecto_ONG_has_proyecto_voluntario.proyecto_ONG_idproyecto_ONG)
            {
                return BadRequest();
            }

            _context.Entry(proyecto_ONG_has_proyecto_voluntario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Proyecto_ONG_has_proyecto_voluntarioExists(id))
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

        // POST: api/Proyecto_ONG_has_proyecto_voluntario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proyecto_ONG_has_proyecto_voluntario>> PostProyecto_ONG_has_proyecto_voluntario(Proyecto_ONG_has_proyecto_voluntario proyecto_ONG_has_proyecto_voluntario)
        {
            _context.ProyectoONGVoluntarios.Add(proyecto_ONG_has_proyecto_voluntario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Proyecto_ONG_has_proyecto_voluntarioExists(proyecto_ONG_has_proyecto_voluntario.proyecto_ONG_idproyecto_ONG))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProyecto_ONG_has_proyecto_voluntario", new { id = proyecto_ONG_has_proyecto_voluntario.proyecto_ONG_idproyecto_ONG }, proyecto_ONG_has_proyecto_voluntario);
        }

        // DELETE: api/Proyecto_ONG_has_proyecto_voluntario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyecto_ONG_has_proyecto_voluntario(int id)
        {
            var proyecto_ONG_has_proyecto_voluntario = await _context.ProyectoONGVoluntarios.FindAsync(id);
            if (proyecto_ONG_has_proyecto_voluntario == null)
            {
                return NotFound();
            }

            _context.ProyectoONGVoluntarios.Remove(proyecto_ONG_has_proyecto_voluntario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Proyecto_ONG_has_proyecto_voluntarioExists(int id)
        {
            return _context.ProyectoONGVoluntarios.Any(e => e.proyecto_ONG_idproyecto_ONG == id);
        }
    }
}
