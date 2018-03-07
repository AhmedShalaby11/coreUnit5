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
    [Route("api/ConfOutcomeStates")]
    public class ConfOutcomeStatesController : Controller
    {
        private readonly unit5Context _context;

        public ConfOutcomeStatesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ConfOutcomeStates
        [HttpGet]
        public IEnumerable<ConfOutcomeState> GetConfOutcomeState()
        {
            return _context.ConfOutcomeState;
        }

        // GET: api/ConfOutcomeStates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfOutcomeState([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confOutcomeState = await _context.ConfOutcomeState.SingleOrDefaultAsync(m => m.Recid == id);

            if (confOutcomeState == null)
            {
                return NotFound();
            }

            return Ok(confOutcomeState);
        }

        // PUT: api/ConfOutcomeStates/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfOutcomeState([FromRoute] int id, [FromBody] ConfOutcomeState confOutcomeState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confOutcomeState.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confOutcomeState).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfOutcomeStateExists(id))
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

        // POST: api/ConfOutcomeStates
        [HttpPost]
        public async Task<IActionResult> PostConfOutcomeState([FromBody] ConfOutcomeState confOutcomeState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfOutcomeState.Add(confOutcomeState);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfOutcomeState", new { id = confOutcomeState.Recid }, confOutcomeState);
        }

        // DELETE: api/ConfOutcomeStates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfOutcomeState([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confOutcomeState = await _context.ConfOutcomeState.SingleOrDefaultAsync(m => m.Recid == id);
            if (confOutcomeState == null)
            {
                return NotFound();
            }

            _context.ConfOutcomeState.Remove(confOutcomeState);
            await _context.SaveChangesAsync();

            return Ok(confOutcomeState);
        }

        private bool ConfOutcomeStateExists(int id)
        {
            return _context.ConfOutcomeState.Any(e => e.Recid == id);
        }
    }
}