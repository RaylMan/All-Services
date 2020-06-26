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
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public CompaniesController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Company>> DeleteCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            var telephones = await _context.Telephones.Where(c => c.CompanyId == id).ToListAsync();
            _context.Telephones.RemoveRange(telephones);

            var addresses = await _context.CompanyAddresses.Where(c => c.CompanyId == id).ToListAsync();
            _context.CompanyAddresses.RemoveRange(addresses);
            
            var types = await _context.CompanyServiceTypes.Where(c => c.CompanyId == id).ToListAsync();
            _context.CompanyServiceTypes.RemoveRange(types);

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();

            return company;
        }
    }
}
