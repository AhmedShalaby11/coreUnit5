using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using unit5.Models;
using System.IO;
namespace unit5.APIs
{
    [Produces("application/json")]
    [Route("api/ConfCsIndications")]
    public class ConfCsIndicationsController : Controller
    {
        private readonly unit5Context _context;

        public ConfCsIndicationsController(unit5Context context)
        {
            _context = context;
        }





        // GET: api/ConfCsIndications InterventionObject
        [HttpGet("/InterventionList")]
        public JsonResult GetConfCsInterventionCustomized()
        {
            var InterventionObject = _context.ConfIntervention.Where(k => k.Type == "Indication").ToList();
           


            return Json(InterventionObject);
        }

        // GET: api/ConfCsIndications IndicationObject
        [HttpGet("/IndicationList")]
        public JsonResult GetIndicationObject()
        {
            var IndicationObject = _context.ConfCsIndication.ToList();


            return Json(IndicationObject);
        }

        // GET: api/ConfCsIndications
        [HttpGet]
        public IEnumerable<ConfCsIndication> GetConfCsIndication()
        {
            return _context.ConfCsIndication;
        }

        // GET: api/ConfCsIndications/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfCsIndication([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confCsIndication = await _context.ConfCsIndication.SingleOrDefaultAsync(m => m.Recid == id);

            if (confCsIndication == null)
            {
                return NotFound();
            }

            return Ok(confCsIndication);
        }

        // PUT: api/ConfCsIndications/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfCsIndication([FromRoute] int id, [FromBody] ConfCsIndication confCsIndication)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != confCsIndication.Recid)
            {
                return BadRequest();
            }

            _context.Entry(confCsIndication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfCsIndicationExists(id))
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

        // POST: api/ConfCsIndications
        [HttpPost]
        public async Task<IActionResult> PostConfCsIndication([FromBody] ConfCsIndication confCsIndication)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ConfCsIndication.Add(confCsIndication);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfCsIndication", new { id = confCsIndication.Recid }, confCsIndication);
        }

        // DELETE: api/ConfCsIndications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfCsIndication([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var confCsIndication = await _context.ConfCsIndication.SingleOrDefaultAsync(m => m.Recid == id);
            if (confCsIndication == null)
            {
                return NotFound();
            }

            _context.ConfCsIndication.Remove(confCsIndication);
            await _context.SaveChangesAsync();

            return Ok(confCsIndication);
        }

        private bool ConfCsIndicationExists(int id)
        {
            return _context.ConfCsIndication.Any(e => e.Recid == id);
        }
    }
}