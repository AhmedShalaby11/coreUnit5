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
    [Route("api/ConfChildPresentations")]
    public class ConfChildPresentationsController : Controller
    {
        private readonly unit5Context _context;

        public ConfChildPresentationsController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ConfChildPresentations
        [HttpGet]
        public IEnumerable<ConfChildPresentation> GetConfChildPresentation()
        {
            return _context.ConfChildPresentation;
        }

        // GET: api/ConfChildPresentations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfChildPresentation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confChildPresentation = await _context.ConfChildPresentation.SingleOrDefaultAsync(m => m.Recid == id);

            if (confChildPresentation == null)
            {
                return NotFound();
            }

            return Ok(confChildPresentation);
        }

        // PUT: api/ConfChildPresentations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfChildPresentation([FromRoute] int id, [FromBody] ConfChildPresentation confChildPresentation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confChildPresentation.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confChildPresentation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfChildPresentationExists(id))
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

        // POST: api/ConfChildPresentations
        [HttpPost]
        public async Task<IActionResult> PostConfChildPresentation([FromBody] ConfChildPresentation confChildPresentation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfChildPresentation.Add(confChildPresentation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfChildPresentation", new { id = confChildPresentation.Recid }, confChildPresentation);
        }

        // DELETE: api/ConfChildPresentations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfChildPresentation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confChildPresentation = await _context.ConfChildPresentation.SingleOrDefaultAsync(m => m.Recid == id);
            if (confChildPresentation == null)
            {
                return NotFound();
            }

            _context.ConfChildPresentation.Remove(confChildPresentation);
            await _context.SaveChangesAsync();

            return Ok(confChildPresentation);
        }

        private bool ConfChildPresentationExists(int id)
        {
            return _context.ConfChildPresentation.Any(e => e.Recid == id);
        }
    }
}