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
    public class ProyectoEmpleadoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProyectoEmpleadoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProyectoEmpleadoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoEmpleado>>> GetProyectoEmpleados()
        {
            return await _context.ProyectoEmpleados.ToListAsync();
        }

        // GET: api/ProyectoEmpleadoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoEmpleado>> GetProyectoEmpleado(int id)
        {
            var proyectoEmpleado = await _context.ProyectoEmpleados.FindAsync(id);

            if (proyectoEmpleado == null)
            {
                return NotFound();
            }

            return proyectoEmpleado;
        }

        // PUT: api/ProyectoEmpleadoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoEmpleado(int id, ProyectoEmpleado proyectoEmpleado)
        {
            if (id != proyectoEmpleado.idproyecto_empleado)
            {
                return BadRequest();
            }

            _context.Entry(proyectoEmpleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoEmpleadoExists(id))
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

        // POST: api/ProyectoEmpleadoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProyectoEmpleado>> PostProyectoEmpleado(ProyectoEmpleado proyectoEmpleado)
        {
            _context.ProyectoEmpleados.Add(proyectoEmpleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProyectoEmpleado", new { id = proyectoEmpleado.idproyecto_empleado }, proyectoEmpleado);
        }

        // DELETE: api/ProyectoEmpleadoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyectoEmpleado(int id)
        {
            var proyectoEmpleado = await _context.ProyectoEmpleados.FindAsync(id);
            if (proyectoEmpleado == null)
            {
                return NotFound();
            }

            _context.ProyectoEmpleados.Remove(proyectoEmpleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProyectoEmpleadoExists(int id)
        {
            return _context.ProyectoEmpleados.Any(e => e.idproyecto_empleado == id);
        }
    }
}
