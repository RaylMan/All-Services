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

namespace All_Services.Controllers.AdminControllers
{
    [Route("api/repairCategory")]
    [ApiController]
    public class RepairCategoriesController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public RepairCategoriesController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/RepairCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RepairCategory>>> GetRepairCategories()
        {
            return await _context.RepairCategories.Include(c => c.ServiceType).ToListAsync();
        }
        
        [HttpGet("sort={typeId}")]
        public async Task<ActionResult<IEnumerable<RepairCategory>>> GetSortedRepairCategories(int typeId)
        {
            var list = await _context.RepairCategories.Where(c => c.ServiceTypeId == typeId).Include(c => c.ServiceType).ToListAsync();
            return list;
        }

        // GET: api/RepairCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RepairCategory>> GetRepairCategory(int id)
        {
            var repairCategory = await _context.RepairCategories.Include(c => c.ServiceType).FirstAsync(c => c.Id == id);

            if (repairCategory == null)
            {
                return NotFound();
            }
            return repairCategory;
        }


        // PUT: api/RepairCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutRepairCategory(int id, RepairCategory repairCategory)
        {
            if (id != repairCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(repairCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RepairCategoryExists(id))
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

        // POST: api/RepairCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<RepairCategory>> PostRepairCategory(RepairCategory repairCategory)
        {
            _context.RepairCategories.Add(repairCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRepairCategory", new { id = repairCategory.Id }, repairCategory);
        }

        // DELETE: api/RepairCategories/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<RepairCategory>> DeleteRepairCategory(int id)
        {
            var repairCategory = await _context.RepairCategories.FindAsync(id);
            if (repairCategory == null)
            {
                return NotFound();
            }

            _context.RepairCategories.Remove(repairCategory);
            await _context.SaveChangesAsync();

            return repairCategory;
        }

        private bool RepairCategoryExists(int id)
        {
            return _context.RepairCategories.Any(e => e.Id == id);
        }
    }
}
