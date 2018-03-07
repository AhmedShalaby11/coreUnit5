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
    [Route("api/PatientDiagnoses")]
    public class PatientDiagnosesController : Controller
    {
        private readonly unit5Context _context;

        public PatientDiagnosesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/PatientDiagnoses
        [HttpGet]
        public IEnumerable<PatientDiagnose> GetPatientDiagnose()
        {
            return _context.PatientDiagnose;
        }

        // GET: api/PatientDiagnoses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientDiagnose([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patientDiagnose = await _context.PatientDiagnose.SingleOrDefaultAsync(m => m.Recid == id);

            if (patientDiagnose == null)
            {
                return NotFound();
            }

            return Ok(patientDiagnose);
        }

        // PUT: api/PatientDiagnoses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientDiagnose([FromRoute] int id, [FromBody] PatientDiagnose patientDiagnose)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patientDiagnose.Recid)
            {
                return BadRequest();
            }

            _context.Entry(patientDiagnose).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientDiagnoseExists(id))
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

        // POST: api/PatientDiagnoses
        [HttpPost]
        public async Task<IActionResult> PostPatientDiagnose([FromBody] PatientDiagnose patientDiagnose)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PatientDiagnose.Add(patientDiagnose);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientDiagnose", new { id = patientDiagnose.Recid }, patientDiagnose);
        }

        // DELETE: api/PatientDiagnoses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientDiagnose([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patientDiagnose = await _context.PatientDiagnose.SingleOrDefaultAsync(m => m.Recid == id);
            if (patientDiagnose == null)
            {
                return NotFound();
            }

            _context.PatientDiagnose.Remove(patientDiagnose);
            await _context.SaveChangesAsync();

            return Ok(patientDiagnose);
        }

        private bool PatientDiagnoseExists(int id)
        {
            return _context.PatientDiagnose.Any(e => e.Recid == id);
        }
    }
}