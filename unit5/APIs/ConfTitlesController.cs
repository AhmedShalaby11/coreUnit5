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
    [Route("api/ConfTitles")]
    public class ConfTitlesController : Controller
    {
        private readonly unit5Context _context;

        public ConfTitlesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ConfTitles
        [HttpGet]
        public IEnumerable<ConfTitle> GetConfTitle()
        {
            return _context.ConfTitle;
        }

        // GET: api/ConfTitles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfTitle([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confTitle = await _context.ConfTitle.SingleOrDefaultAsync(m => m.Recid == id);

            if (confTitle == null)
            {
                return NotFound();
            }

            return Ok(confTitle);
        }

        // PUT: api/ConfTitles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfTitle([FromRoute] int id, [FromBody] ConfTitle confTitle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confTitle.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confTitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfTitleExists(id))
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

        // POST: api/ConfTitles
        [HttpPost]
        public async Task<IActionResult> PostConfTitle([FromBody] ConfTitle confTitle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfTitle.Add(confTitle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfTitle", new { id = confTitle.Recid }, confTitle);
        }

        // DELETE: api/ConfTitles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfTitle([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confTitle = await _context.ConfTitle.SingleOrDefaultAsync(m => m.Recid == id);
            if (confTitle == null)
            {
                return NotFound();
            }

            _context.ConfTitle.Remove(confTitle);
            await _context.SaveChangesAsync();

            return Ok(confTitle);
        }

        private bool ConfTitleExists(int id)
        {
            return _context.ConfTitle.Any(e => e.Recid == id);
        }
    }
}