using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using unit5.Models;

namespace unit5.APIs
{
    [Produces("application/json")]
    [Route("api/NeonatalOutcomes")]
    public class NeonatalOutcomesController : Controller
    {
        private readonly unit5Context _context;

        public NeonatalOutcomesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/NeonatalOutcomes
        [HttpGet]
        public IEnumerable<NeonatalOutcome> GetNeonatalOutcome()
        {
            return _context.NeonatalOutcome;
        }

        // GET: api/NeonatalOutcomes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNeonatalOutcome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var neonatalOutcome = await _context.NeonatalOutcome.SingleOrDefaultAsync(m => m.Id == id);

            if (neonatalOutcome == null)
            {
                return NotFound();
            }

            return Ok(neonatalOutcome);
        }

        // PUT: api/NeonatalOutcomes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNeonatalOutcome([FromRoute] int id, [FromBody] NeonatalOutcome neonatalOutcome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != neonatalOutcome.Id)
            {
                return BadRequest();
            }

            _context.Entry(neonatalOutcome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NeonatalOutcomeExists(id))
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

        // POST: api/NeonatalOutcomes
        [HttpPost]
        public async Task<IActionResult> PostNeonatalOutcome([FromBody] NeonatalOutcome neonatalOutcome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.NeonatalOutcome.Add(neonatalOutcome);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNeonatalOutcome", new { id = neonatalOutcome.Id }, neonatalOutcome);
        }

        // DELETE: api/NeonatalOutcomes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNeonatalOutcome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var neonatalOutcome = await _context.NeonatalOutcome.SingleOrDefaultAsync(m => m.Id == id);
            if (neonatalOutcome == null)
            {
                return NotFound();
            }

            _context.NeonatalOutcome.Remove(neonatalOutcome);
            await _context.SaveChangesAsync();

            return Ok(neonatalOutcome);
        }

        private bool NeonatalOutcomeExists(int id)
        {
            return _context.NeonatalOutcome.Any(e => e.Id == id);
        }
    }
}