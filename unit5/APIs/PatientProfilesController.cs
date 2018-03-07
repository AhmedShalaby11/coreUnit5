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
    [Route("api/PatientProfiles")]
    public class PatientProfilesController : Controller
    {
        private readonly unit5Context _context;

        public PatientProfilesController(unit5Context context)
        {
            _context = context;
        }

        // GET: api/PatientProfiles
        [HttpGet]
        public IEnumerable<PatientProfile> GetPatientProfile()
        {
            return _context.PatientProfile;
        }

        // GET: api/PatientProfiles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientProfile([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patientProfile = await _context.PatientProfile.SingleOrDefaultAsync(m => m.Recid == id);

            if (patientProfile == null)
            {
                return NotFound();
            }

            return Ok(patientProfile);
        }

        // PUT: api/PatientProfiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientProfile([FromRoute] int id, [FromBody] PatientProfile patientProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patientProfile.Recid)
            {
                return BadRequest();
            }

            _context.Entry(patientProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientProfileExists(id))
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

        // POST: api/PatientProfiles
        [HttpPost]
        public async Task<IActionResult> PostPatientProfile([FromBody] PatientProfile patientProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PatientProfile.Add(patientProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientProfile", new { id = patientProfile.Recid }, patientProfile);
        }

        // DELETE: api/PatientProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientProfile([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patientProfile = await _context.PatientProfile.SingleOrDefaultAsync(m => m.Recid == id);
            if (patientProfile == null)
            {
                return NotFound();
            }

            _context.PatientProfile.Remove(patientProfile);
            await _context.SaveChangesAsync();

            return Ok(patientProfile);
        }

        private bool PatientProfileExists(int id)
        {
            return _context.PatientProfile.Any(e => e.Recid == id);
        }
    }
}