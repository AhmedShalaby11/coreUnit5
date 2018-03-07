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
    [Route("api/ConfOutcomes")]
    public class ConfOutcomesController : Controller
    {
        private readonly unit5Context _context;

        public ConfOutcomesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ConfOutcomes
        [HttpGet]
        public IEnumerable<ConfOutcome> GetConfOutcome()
        {
            return _context.ConfOutcome;
        }

        // GET: api/ConfOutcomes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfOutcome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confOutcome = await _context.ConfOutcome.SingleOrDefaultAsync(m => m.Recid == id);

            if (confOutcome == null)
            {
                return NotFound();
            }

            return Ok(confOutcome);
        }

        // PUT: api/ConfOutcomes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfOutcome([FromRoute] int id, [FromBody] ConfOutcome confOutcome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confOutcome.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confOutcome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfOutcomeExists(id))
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

        // POST: api/ConfOutcomes
        [HttpPost]
        public async Task<IActionResult> PostConfOutcome([FromBody] ConfOutcome confOutcome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfOutcome.Add(confOutcome);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfOutcome", new { id = confOutcome.Recid }, confOutcome);
        }

        // DELETE: api/ConfOutcomes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfOutcome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confOutcome = await _context.ConfOutcome.SingleOrDefaultAsync(m => m.Recid == id);
            if (confOutcome == null)
            {
                return NotFound();
            }

            _context.ConfOutcome.Remove(confOutcome);
            await _context.SaveChangesAsync();

            return Ok(confOutcome);
        }

        private bool ConfOutcomeExists(int id)
        {
            return _context.ConfOutcome.Any(e => e.Recid == id);
        }
    }
}