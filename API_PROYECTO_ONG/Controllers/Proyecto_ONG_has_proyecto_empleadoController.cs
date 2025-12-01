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
    public class Proyecto_ONG_has_proyecto_empleadoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Proyecto_ONG_has_proyecto_empleadoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Proyecto_ONG_has_proyecto_empleado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proyecto_ONG_has_proyecto_empleado>>> GetProyectoONGEmpleados()
        {
            return await _context.ProyectoONGEmpleados.ToListAsync();
        }

        // GET: api/Proyecto_ONG_has_proyecto_empleado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proyecto_ONG_has_proyecto_empleado>> GetProyecto_ONG_has_proyecto_empleado(int id)
        {
            var proyecto_ONG_has_proyecto_empleado = await _context.ProyectoONGEmpleados.FindAsync(id);

            if (proyecto_ONG_has_proyecto_empleado == null)
            {
                return NotFound();
            }

            return proyecto_ONG_has_proyecto_empleado;
        }

        // PUT: api/Proyecto_ONG_has_proyecto_empleado/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyecto_ONG_has_proyecto_empleado(int id, Proyecto_ONG_has_proyecto_empleado proyecto_ONG_has_proyecto_empleado)
        {
            if (id != proyecto_ONG_has_proyecto_empleado.proyecto_ONG_idproyecto_ONG)
            {
                return BadRequest();
            }

            _context.Entry(proyecto_ONG_has_proyecto_empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Proyecto_ONG_has_proyecto_empleadoExists(id))
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

        // POST: api/Proyecto_ONG_has_proyecto_empleado
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proyecto_ONG_has_proyecto_empleado>> PostProyecto_ONG_has_proyecto_empleado(Proyecto_ONG_has_proyecto_empleado proyecto_ONG_has_proyecto_empleado)
        {
            _context.ProyectoONGEmpleados.Add(proyecto_ONG_has_proyecto_empleado);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Proyecto_ONG_has_proyecto_empleadoExists(proyecto_ONG_has_proyecto_empleado.proyecto_ONG_idproyecto_ONG))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProyecto_ONG_has_proyecto_empleado", new { id = proyecto_ONG_has_proyecto_empleado.proyecto_ONG_idproyecto_ONG }, proyecto_ONG_has_proyecto_empleado);
        }

        // DELETE: api/Proyecto_ONG_has_proyecto_empleado/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyecto_ONG_has_proyecto_empleado(int id)
        {
            var proyecto_ONG_has_proyecto_empleado = await _context.ProyectoONGEmpleados.FindAsync(id);
            if (proyecto_ONG_has_proyecto_empleado == null)
            {
                return NotFound();
            }

            _context.ProyectoONGEmpleados.Remove(proyecto_ONG_has_proyecto_empleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Proyecto_ONG_has_proyecto_empleadoExists(int id)
        {
            return _context.ProyectoONGEmpleados.Any(e => e.proyecto_ONG_idproyecto_ONG == id);
        }
    }
}
