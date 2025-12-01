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
    public class ProyectoVoluntariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProyectoVoluntariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProyectoVoluntarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoVoluntario>>> GetProyectoVoluntarios()
        {
            return await _context.ProyectoVoluntarios.ToListAsync();
        }

        // GET: api/ProyectoVoluntarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoVoluntario>> GetProyectoVoluntario(int id)
        {
            var proyectoVoluntario = await _context.ProyectoVoluntarios.FindAsync(id);

            if (proyectoVoluntario == null)
            {
                return NotFound();
            }

            return proyectoVoluntario;
        }

        // PUT: api/ProyectoVoluntarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoVoluntario(int id, ProyectoVoluntario proyectoVoluntario)
        {
            if (id != proyectoVoluntario.idproyecto_voluntario)
            {
                return BadRequest();
            }

            _context.Entry(proyectoVoluntario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoVoluntarioExists(id))
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

        // POST: api/ProyectoVoluntarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProyectoVoluntario>> PostProyectoVoluntario(ProyectoVoluntario proyectoVoluntario)
        {
            _context.ProyectoVoluntarios.Add(proyectoVoluntario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProyectoVoluntario", new { id = proyectoVoluntario.idproyecto_voluntario }, proyectoVoluntario);
        }

        // DELETE: api/ProyectoVoluntarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyectoVoluntario(int id)
        {
            var proyectoVoluntario = await _context.ProyectoVoluntarios.FindAsync(id);
            if (proyectoVoluntario == null)
            {
                return NotFound();
            }

            _context.ProyectoVoluntarios.Remove(proyectoVoluntario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProyectoVoluntarioExists(int id)
        {
            return _context.ProyectoVoluntarios.Any(e => e.idproyecto_voluntario == id);
        }
    }
}
