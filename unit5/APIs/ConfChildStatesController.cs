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
    [Route("api/ConfChildStates")]
    public class ConfChildStatesController : Controller
    {
        private readonly unit5Context _context;

        public ConfChildStatesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ConfChildStates
        [HttpGet]
        public IEnumerable<ConfChildState> GetConfChildState()
        {
            return _context.ConfChildState;
        }

        // GET: api/ConfChildStates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfChildState([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confChildState = await _context.ConfChildState.SingleOrDefaultAsync(m => m.Recid == id);

            if (confChildState == null)
            {
                return NotFound();
            }

            return Ok(confChildState);
        }

        // PUT: api/ConfChildStates/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfChildState([FromRoute] int id, [FromBody] ConfChildState confChildState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confChildState.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confChildState).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfChildStateExists(id))
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

        // POST: api/ConfChildStates
        [HttpPost]
        public async Task<IActionResult> PostConfChildState([FromBody] ConfChildState confChildState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfChildState.Add(confChildState);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfChildState", new { id = confChildState.Recid }, confChildState);
        }

        // DELETE: api/ConfChildStates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfChildState([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confChildState = await _context.ConfChildState.SingleOrDefaultAsync(m => m.Recid == id);
            if (confChildState == null)
            {
                return NotFound();
            }

            _context.ConfChildState.Remove(confChildState);
            await _context.SaveChangesAsync();

            return Ok(confChildState);
        }

        private bool ConfChildStateExists(int id)
        {
            return _context.ConfChildState.Any(e => e.Recid == id);
        }
    }
}