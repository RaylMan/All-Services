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
using All_Services.ViewModels.Admin;

namespace All_Services.Controllers.AdminControllers
{
    [Route("api/equipments")]
    [ApiController]
   
    public class EquipmentsController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public EquipmentsController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/Equipments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipment()
        {
            //var result = from equipment in _context.Equipment
            //             join manufacturer in _context.Manufacturers on equipment.ManufacturerId equals manufacturer.Id
            //             join equipmentType in _context.EquipmentTypes on equipment.TypeId equals equipmentType.Id
            //             select new 
            //             {
            //                 Id = equipment.Id,
            //                 Model = equipment.Model,
            //                 Manufacturer = manufacturer.Name,
            //                 EquipmentType = equipmentType.Name
            //             }; .Include(e => e.Manufacturer)
            var result = await _context.Equipment.Include(t => t.EquipmentType).Include(e => e.Manufacturer).ToListAsync();
            return result;
        }
        // GET: api/Equipments
        [HttpGet("sort={typeId}+{mfId}")]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetSortedEquipment(int typeId, int mfId)
        {
            if(typeId == -1)
            {
                return await _context.Equipment.Where(e => e.ManufacturerId == mfId)
                    .Include(e => e.Manufacturer)
                    .Include(e => e.EquipmentType)
                    .ToListAsync();
            }
            else if(mfId == -1)
            {
                return await _context.Equipment.Where(e => e.EquipmentTypeId == typeId)
                    .Include(e => e.Manufacturer)
                    .Include(e => e.EquipmentType)
                    .ToListAsync();
            }
            else
            {
                return await _context.Equipment.Where(e => e.EquipmentTypeId == typeId && e.ManufacturerId == mfId)
                    .Include(e => e.Manufacturer)
                    .Include(e => e.EquipmentType)
                    .ToListAsync();
            }
           
        }

        // GET: api/Equipments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipment>> GetEquipment(int id)
        {
            var equipment = await _context.Equipment.Include(e => e.EquipmentType).Include(e => e.Manufacturer).FirstAsync(e => e.Id == id);

            if (equipment == null)
            {
                return NotFound();
            }

            return equipment;
        }

        // PUT: api/Equipments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutEquipment(int id, Equipment equipment)
        {
            if (id != equipment.Id)
            {
                return BadRequest();
            }

            _context.Entry(equipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentExists(id))
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

        // POST: api/Equipments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Equipment>> PostEquipment(Equipment equipment)
        {
            _context.Equipment.Add(equipment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipment", new { id = equipment.Id }, equipment);
        }

        // DELETE: api/Equipments/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Equipment>> DeleteEquipment(int id)
        {
            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }

            _context.Equipment.Remove(equipment);
            await _context.SaveChangesAsync();

            return equipment;
        }

        private bool EquipmentExists(int id)
        {
            return _context.Equipment.Any(e => e.Id == id);
        }
    }
}
