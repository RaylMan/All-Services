using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllServicesData.EF;
using AllServicesData.Model;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace All_Services.Controllers.ServicesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public SearchController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/Search/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanyByType(int id)
        {
            var companies = await _context.Companies.Include(c => c.CompanyServiceType)
                                                    .Include(t => t.Telephones)
                                                    .Where(c => c.CompanyServiceType.Where(t => t.ServiceTypeId == id).Count() > 0)
                                                    .ToListAsync();
            if (companies == null)
            {
                return NotFound();
            }

            return companies;
        }

    }
}
