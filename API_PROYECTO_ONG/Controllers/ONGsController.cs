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
    public class ONGsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ONGsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONGs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ONG>>> GetONGs()
        {
            return await _context.ONGs.ToListAsync();
        }

        // GET: api/ONGs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ONG>> GetONG(int id)
        {
            var oNG = await _context.ONGs.FindAsync(id);

            if (oNG == null)
            {
                return NotFound();
            }

            return oNG;
        }

        // PUT: api/ONGs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutONG(int id, ONG oNG)
        {
            if (id != oNG.idONG)
            {
                return BadRequest();
            }

            _context.Entry(oNG).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ONGExists(id))
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

        // POST: api/ONGs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ONG>> PostONG(ONG oNG)
        {
            _context.ONGs.Add(oNG);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetONG", new { id = oNG.idONG }, oNG);
        }

        // DELETE: api/ONGs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteONG(int id)
        {
            var oNG = await _context.ONGs.FindAsync(id);
            if (oNG == null)
            {
                return NotFound();
            }

            _context.ONGs.Remove(oNG);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ONGExists(int id)
        {
            return _context.ONGs.Any(e => e.idONG == id);
        }
    }
}
