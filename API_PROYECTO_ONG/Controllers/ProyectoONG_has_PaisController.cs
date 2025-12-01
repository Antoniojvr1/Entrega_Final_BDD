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
    public class ProyectoONG_has_PaisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProyectoONG_has_PaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProyectoONG_has_Pais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoONG_has_Pais>>> GetProyectoPaises()
        {
            return await _context.ProyectoPaises.ToListAsync();
        }

        // GET: api/ProyectoONG_has_Pais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoONG_has_Pais>> GetProyectoONG_has_Pais(int id)
        {
            var proyectoONG_has_Pais = await _context.ProyectoPaises.FindAsync(id);

            if (proyectoONG_has_Pais == null)
            {
                return NotFound();
            }

            return proyectoONG_has_Pais;
        }

        // PUT: api/ProyectoONG_has_Pais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoONG_has_Pais(int id, ProyectoONG_has_Pais proyectoONG_has_Pais)
        {
            if (id != proyectoONG_has_Pais.proyecto_ONG_idproyecto_ONG)
            {
                return BadRequest();
            }

            _context.Entry(proyectoONG_has_Pais).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoONG_has_PaisExists(id))
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

        // POST: api/ProyectoONG_has_Pais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProyectoONG_has_Pais>> PostProyectoONG_has_Pais(ProyectoONG_has_Pais proyectoONG_has_Pais)
        {
            _context.ProyectoPaises.Add(proyectoONG_has_Pais);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProyectoONG_has_PaisExists(proyectoONG_has_Pais.proyecto_ONG_idproyecto_ONG))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProyectoONG_has_Pais", new { id = proyectoONG_has_Pais.proyecto_ONG_idproyecto_ONG }, proyectoONG_has_Pais);
        }

        // DELETE: api/ProyectoONG_has_Pais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyectoONG_has_Pais(int id)
        {
            var proyectoONG_has_Pais = await _context.ProyectoPaises.FindAsync(id);
            if (proyectoONG_has_Pais == null)
            {
                return NotFound();
            }

            _context.ProyectoPaises.Remove(proyectoONG_has_Pais);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProyectoONG_has_PaisExists(int id)
        {
            return _context.ProyectoPaises.Any(e => e.proyecto_ONG_idproyecto_ONG == id);
        }
    }
}
