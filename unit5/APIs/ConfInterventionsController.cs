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
    [Route("api/ConfInterventions")]
    public class ConfInterventionsController : Controller
    {
        private readonly unit5Context _context;

        public ConfInterventionsController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ConfInterventions
        [HttpGet]
        public IEnumerable<ConfIntervention> GetConfIntervention()
        {
            return _context.ConfIntervention;
        }

        // GET: api/ConfInterventions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfIntervention([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confIntervention = await _context.ConfIntervention.SingleOrDefaultAsync(m => m.Recid == id);

            if (confIntervention == null)
            {
                return NotFound();
            }

            return Ok(confIntervention);
        }

        // PUT: api/ConfInterventions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfIntervention([FromRoute] int id, [FromBody] ConfIntervention confIntervention)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confIntervention.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confIntervention).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfInterventionExists(id))
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

        // POST: api/ConfInterventions
        [HttpPost]
        public async Task<IActionResult> PostConfIntervention([FromBody] ConfIntervention confIntervention)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfIntervention.Add(confIntervention);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfIntervention", new { id = confIntervention.Recid }, confIntervention);
        }

        // DELETE: api/ConfInterventions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfIntervention([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confIntervention = await _context.ConfIntervention.SingleOrDefaultAsync(m => m.Recid == id);
            if (confIntervention == null)
            {
                return NotFound();
            }

            _context.ConfIntervention.Remove(confIntervention);
            await _context.SaveChangesAsync();

            return Ok(confIntervention);
        }

        private bool ConfInterventionExists(int id)
        {
            return _context.ConfIntervention.Any(e => e.Recid == id);
        }
    }
}