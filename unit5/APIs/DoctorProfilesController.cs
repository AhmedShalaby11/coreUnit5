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
    [Route("api/DoctorProfiles")]
    public class DoctorProfilesController : Controller
    {
        private readonly unit5Context _context;

        public DoctorProfilesController(unit5Context context)
        {
            _context = context;
        }



        // GET: api/DoctorProfiles
        [HttpGet]
        public JsonResult GetDoctorProfile()
        {

            var ProfileObject = (from p in _context.DoctorProfile
                                 select new
                                 {
                                    p.DoctorName,
                                    p.DoctorOtherDegrees
                                 }
                                 
                                 ).ToList();


           
            return Json(ProfileObject);
        }

        // GET: api/DoctorProfiles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorProfile([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctorProfile = await _context.DoctorProfile.SingleOrDefaultAsync(m => m.Recid == id);

            if (doctorProfile == null)
            {
                return NotFound();
            }

            return Ok(doctorProfile);
        }

        // PUT: api/DoctorProfiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctorProfile([FromRoute] int id, [FromBody] DoctorProfile doctorProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != doctorProfile.Recid)
            {
                return BadRequest();
            }

            _context.Entry(doctorProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctorProfileExists(id))
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

        // POST: api/DoctorProfiles
        [HttpPost]
        public async Task<IActionResult> PostDoctorProfile([FromBody] DoctorProfile doctorProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DoctorProfile.Add(doctorProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoctorProfile", new { id = doctorProfile.Recid }, doctorProfile);
        }

        // DELETE: api/DoctorProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctorProfile([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctorProfile = await _context.DoctorProfile.SingleOrDefaultAsync(m => m.Recid == id);
            if (doctorProfile == null)
            {
                return NotFound();
            }

            _context.DoctorProfile.Remove(doctorProfile);
            await _context.SaveChangesAsync();

            return Ok(doctorProfile);
        }

        private bool DoctorProfileExists(int id)
        {
            return _context.DoctorProfile.Any(e => e.Recid == id);
        }
    }
}