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
    public class CuentaBancariasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CuentaBancariasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CuentaBancarias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuentaBancaria>>> GetCuentasBancarias()
        {
            return await _context.CuentasBancarias.ToListAsync();
        }

        // GET: api/CuentaBancarias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CuentaBancaria>> GetCuentaBancaria(int id)
        {
            var cuentaBancaria = await _context.CuentasBancarias.FindAsync(id);

            if (cuentaBancaria == null)
            {
                return NotFound();
            }

            return cuentaBancaria;
        }

        // PUT: api/CuentaBancarias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuentaBancaria(int id, CuentaBancaria cuentaBancaria)
        {
            if (id != cuentaBancaria.idcuentaBancaria)
            {
                return BadRequest();
            }

            _context.Entry(cuentaBancaria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuentaBancariaExists(id))
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

        // POST: api/CuentaBancarias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CuentaBancaria>> PostCuentaBancaria(CuentaBancaria cuentaBancaria)
        {
            _context.CuentasBancarias.Add(cuentaBancaria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuentaBancaria", new { id = cuentaBancaria.idcuentaBancaria }, cuentaBancaria);
        }

        // DELETE: api/CuentaBancarias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuentaBancaria(int id)
        {
            var cuentaBancaria = await _context.CuentasBancarias.FindAsync(id);
            if (cuentaBancaria == null)
            {
                return NotFound();
            }

            _context.CuentasBancarias.Remove(cuentaBancaria);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CuentaBancariaExists(int id)
        {
            return _context.CuentasBancarias.Any(e => e.idcuentaBancaria == id);
        }
    }
}
