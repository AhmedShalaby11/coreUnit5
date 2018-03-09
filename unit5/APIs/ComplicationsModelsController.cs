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
    [Route("api/ComplicationsModels")]
    public class ComplicationsModelsController : Controller
    {
        private readonly unit5Context _context;

        public ComplicationsModelsController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/ComplicationsModels
        [HttpGet]
        public IEnumerable<ComplicationsModel> GetComplicaitons()
        {
            return _context.Complicaitons;
        }

        // GET: api/ComplicationsModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComplicationsModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var complicationsModel = await _context.Complicaitons.SingleOrDefaultAsync(m => m.Id == id);

            if (complicationsModel == null)
            {
                return NotFound();
            }

            return Ok(complicationsModel);
        }

        // PUT: api/ComplicationsModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplicationsModel([FromRoute] int id, [FromBody] ComplicationsModel complicationsModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != complicationsModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(complicationsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplicationsModelExists(id))
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

        // POST: api/ComplicationsModels
        [HttpPost]
        public async Task<IActionResult> PostComplicationsModel([FromBody] ComplicationsModel complicationsModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Complicaitons.Add(complicationsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplicationsModel", new { id = complicationsModel.Id }, complicationsModel);
        }

        // DELETE: api/ComplicationsModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplicationsModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var complicationsModel = await _context.Complicaitons.SingleOrDefaultAsync(m => m.Id == id);
            if (complicationsModel == null)
            {
                return NotFound();
            }

            _context.Complicaitons.Remove(complicationsModel);
            await _context.SaveChangesAsync();

            return Ok(complicationsModel);
        }

        private bool ComplicationsModelExists(int id)
        {
            return _context.Complicaitons.Any(e => e.Id == id);
        }
    }
}