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
    [Route("api/CasulityDataClasses")]
    public class CasulityDataClassesController : Controller
    {
        private readonly unit5Context _context;

        public CasulityDataClassesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/CasulityDataClasses
        [HttpGet]
        public IEnumerable<CasulityDataClass> GetCasulityProfile()
        {
            return _context.CasulityProfile;
        }

        // GET: api/CasulityDataClasses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCasulityDataClass([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var casulityDataClass = await _context.CasulityProfile.SingleOrDefaultAsync(m => m.Id == id);

            if (casulityDataClass == null)
            {
                return NotFound();
            }

            return Ok(casulityDataClass);
        }

        // PUT: api/CasulityDataClasses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCasulityDataClass([FromRoute] int id, [FromBody] CasulityDataClass casulityDataClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != casulityDataClass.Id)
            {
                return BadRequest();
            }

            _context.Entry(casulityDataClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CasulityDataClassExists(id))
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

        // POST: api/CasulityDataClasses
        [HttpPost]
        public async Task<IActionResult> PostCasulityDataClass([FromBody] CasulityDataClass casulityDataClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CasulityProfile.Add(casulityDataClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCasulityDataClass", new { id = casulityDataClass.Id }, casulityDataClass);
        }

        // DELETE: api/CasulityDataClasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCasulityDataClass([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var casulityDataClass = await _context.CasulityProfile.SingleOrDefaultAsync(m => m.Id == id);
            if (casulityDataClass == null)
            {
                return NotFound();
            }

            _context.CasulityProfile.Remove(casulityDataClass);
            await _context.SaveChangesAsync();

            return Ok(casulityDataClass);
        }

        private bool CasulityDataClassExists(int id)
        {
            return _context.CasulityProfile.Any(e => e.Id == id);
        }
    }
}