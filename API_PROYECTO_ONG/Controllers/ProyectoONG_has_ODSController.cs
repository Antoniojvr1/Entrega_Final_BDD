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
    public class ProyectoONG_has_ODSController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProyectoONG_has_ODSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProyectoONG_has_ODS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoONG_has_ODS>>> GetProyectoODS()
        {
            return await _context.ProyectoODS.ToListAsync();
        }

        // GET: api/ProyectoONG_has_ODS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoONG_has_ODS>> GetProyectoONG_has_ODS(int id)
        {
            var proyectoONG_has_ODS = await _context.ProyectoODS.FindAsync(id);

            if (proyectoONG_has_ODS == null)
            {
                return NotFound();
            }

            return proyectoONG_has_ODS;
        }

        // PUT: api/ProyectoONG_has_ODS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoONG_has_ODS(int id, ProyectoONG_has_ODS proyectoONG_has_ODS)
        {
            if (id != proyectoONG_has_ODS.proyecto_ONG_idproyecto_ONG)
            {
                return BadRequest();
            }

            _context.Entry(proyectoONG_has_ODS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoONG_has_ODSExists(id))
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

        // POST: api/ProyectoONG_has_ODS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProyectoONG_has_ODS>> PostProyectoONG_has_ODS(ProyectoONG_has_ODS proyectoONG_has_ODS)
        {
            _context.ProyectoODS.Add(proyectoONG_has_ODS);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProyectoONG_has_ODSExists(proyectoONG_has_ODS.proyecto_ONG_idproyecto_ONG))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProyectoONG_has_ODS", new { id = proyectoONG_has_ODS.proyecto_ONG_idproyecto_ONG }, proyectoONG_has_ODS);
        }

        // DELETE: api/ProyectoONG_has_ODS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyectoONG_has_ODS(int id)
        {
            var proyectoONG_has_ODS = await _context.ProyectoODS.FindAsync(id);
            if (proyectoONG_has_ODS == null)
            {
                return NotFound();
            }

            _context.ProyectoODS.Remove(proyectoONG_has_ODS);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProyectoONG_has_ODSExists(int id)
        {
            return _context.ProyectoODS.Any(e => e.proyecto_ONG_idproyecto_ONG == id);
        }
    }
}
