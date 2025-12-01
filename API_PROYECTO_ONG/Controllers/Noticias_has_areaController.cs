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
    public class Noticias_has_areaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Noticias_has_areaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Noticias_has_area
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Noticias_has_area>>> GetNoticiasAreas()
        {
            return await _context.NoticiasAreas.ToListAsync();
        }

        // GET: api/Noticias_has_area/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Noticias_has_area>> GetNoticias_has_area(int id)
        {
            var noticias_has_area = await _context.NoticiasAreas.FindAsync(id);

            if (noticias_has_area == null)
            {
                return NotFound();
            }

            return noticias_has_area;
        }

        // PUT: api/Noticias_has_area/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNoticias_has_area(int id, Noticias_has_area noticias_has_area)
        {
            if (id != noticias_has_area.Noticias_idNoticias)
            {
                return BadRequest();
            }

            _context.Entry(noticias_has_area).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Noticias_has_areaExists(id))
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

        // POST: api/Noticias_has_area
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Noticias_has_area>> PostNoticias_has_area(Noticias_has_area noticias_has_area)
        {
            _context.NoticiasAreas.Add(noticias_has_area);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Noticias_has_areaExists(noticias_has_area.Noticias_idNoticias))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNoticias_has_area", new { id = noticias_has_area.Noticias_idNoticias }, noticias_has_area);
        }

        // DELETE: api/Noticias_has_area/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNoticias_has_area(int id)
        {
            var noticias_has_area = await _context.NoticiasAreas.FindAsync(id);
            if (noticias_has_area == null)
            {
                return NotFound();
            }

            _context.NoticiasAreas.Remove(noticias_has_area);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Noticias_has_areaExists(int id)
        {
            return _context.NoticiasAreas.Any(e => e.Noticias_idNoticias == id);
        }
    }
}
