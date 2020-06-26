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
    [Route("api/equipmentTypes")]
    [ApiController]
    public class EquipmentTypesController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public EquipmentTypesController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/EquipmentTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentType>>> GetEquipmentTypes()
        {
            return await _context.EquipmentTypes.Include(c => c.ServiceType).ToListAsync();
        }
        [HttpGet("sort={typeId}")]
        public async Task<ActionResult<IEnumerable<EquipmentType>>> GetSortedEquipmentTypes(int typeId)
        {
            return await _context.EquipmentTypes.Where(c => c.ServiceTypeId == typeId).Include(c => c.ServiceType).ToListAsync();
        }

        // GET: api/EquipmentTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipmentType>> GetEquipmentType(int id)
        {
            var equipmentType = await _context.EquipmentTypes.Include(c => c.ServiceType).FirstAsync(c => c.Id == id);

            if (equipmentType == null)
            {
                return NotFound();
            }

            return equipmentType;
        }

        // PUT: api/EquipmentTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutEquipmentType(int id, EquipmentType equipmentType)
        {
            if (id != equipmentType.Id)
            {
                return BadRequest();
            }

            _context.Entry(equipmentType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentTypeExists(id))
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

        // POST: api/EquipmentTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<EquipmentType>> PostEquipmentType(EquipmentType equipmentType)
        {
            _context.EquipmentTypes.Add(equipmentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipmentType", new { id = equipmentType.Id }, equipmentType);
        }

        // DELETE: api/EquipmentTypes/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<EquipmentType>> DeleteEquipmentType(int id)
        {
            var equipmentType = await _context.EquipmentTypes.FindAsync(id);
            if (equipmentType == null)
            {
                return NotFound();
            }

            _context.EquipmentTypes.Remove(equipmentType);
            await _context.SaveChangesAsync();

            return equipmentType;
        }

        private bool EquipmentTypeExists(int id)
        {
            return _context.EquipmentTypes.Any(e => e.Id == id);
        }
    }
}
