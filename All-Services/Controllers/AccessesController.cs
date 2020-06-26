using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllServicesData.EF;
using AllServicesData.Model;
using Microsoft.AspNetCore.Authorization;

namespace All_Services.Controllers
{
    [Route("api/access")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AccessesController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public AccessesController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/Accesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Access>>> GetAccess()
        {
            return await _context.Access.ToListAsync();
        }

        // GET: api/Accesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Access>> GetAccess(int id)
        {
            var access = await _context.Access.FindAsync(id);

            if (access == null)
            {
                return NotFound();
            }

            return access;
        }

        // PUT: api/Accesses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccess(int id, Access access)
        {
            if (id != access.Id)
            {
                return BadRequest();
            }

            _context.Entry(access).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccessExists(id))
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

        // POST: api/Accesses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Access>> PostAccess(Access access)
        {
            _context.Access.Add(access);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccess", new { id = access.Id }, access);
        }

        // DELETE: api/Accesses/5
        [HttpDelete("{id}")]
        
        public async Task<ActionResult<Access>> DeleteAccess(int id)
        {
            var access = await _context.Access.FindAsync(id);
            if (access == null)
            {
                return NotFound();
            }

            _context.Access.Remove(access);
            await _context.SaveChangesAsync();

            return access;
        }

        private bool AccessExists(int id)
        {
            return _context.Access.Any(e => e.Id == id);
        }
    }
}
