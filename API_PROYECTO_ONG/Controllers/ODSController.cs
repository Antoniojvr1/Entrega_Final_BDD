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
    public class ODSController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ODSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ODS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ODS>>> GetODS()
        {
            return await _context.ODS.ToListAsync();
        }

        // GET: api/ODS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ODS>> GetODS(int id)
        {
            var oDS = await _context.ODS.FindAsync(id);

            if (oDS == null)
            {
                return NotFound();
            }

            return oDS;
        }

        // PUT: api/ODS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutODS(int id, ODS oDS)
        {
            if (id != oDS.idODS)
            {
                return BadRequest();
            }

            _context.Entry(oDS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ODSExists(id))
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

        // POST: api/ODS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ODS>> PostODS(ODS oDS)
        {
            _context.ODS.Add(oDS);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetODS", new { id = oDS.idODS }, oDS);
        }

        // DELETE: api/ODS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteODS(int id)
        {
            var oDS = await _context.ODS.FindAsync(id);
            if (oDS == null)
            {
                return NotFound();
            }

            _context.ODS.Remove(oDS);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ODSExists(int id)
        {
            return _context.ODS.Any(e => e.idODS == id);
        }
    }
}
