using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllServicesData.EF;
using AllServicesData.Model;
using Microsoft.Data.SqlClient;
using System.Linq;
using All_Services.ViewModels.Company;

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
        public async Task<ActionResult<IEnumerable<SearchCompanyViewModel>>> GetCompanyByType(int id)
        {
            var companies = await _context.Companies.Include(c => c.CompanyServiceType)
                                                    .Include(t => t.Telephones)
                                                    .Where(c => c.CompanyServiceType.Where(t => t.ServiceTypeId == id).Count() > 0)
                                                    .Select(comp => new SearchCompanyViewModel
                                                    {
                                                        CompanyId = comp.Id,
                                                        Name = comp.Name,
                                                        Desc = comp.SmallDescription,
                                                        LogoUrl = comp.LogoUrl,
                                                        WebSiteUrl = comp.WebSiteUrl,
                                                        Likes = comp.Likes,
                                                        DisLikes = comp.Dislikes,
                                                        Telephone = comp.Telephones.First().Telephone
                                                    })
                                                    .ToListAsync();
            if (companies == null)
            {
                return NotFound();
            }

            return companies;
        }
        //api/search/search?text=a&index=0count=20
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<SearchCompanyViewModel>>> Search(string text, int index, int count)
        {
            var result = await (from comp in _context.Companies.OrderByDescending(c => c.Popularity).Include(c => c.Telephones)
                         join manuf in _context.CompanyManufacturers.Include(m => m.Manufacturer) on comp.Id equals manuf.CompanyId
                         join type in _context.CompanyServiceType.Include(t => t.ServiceType) on comp.Id equals type.CompanyId

                         where manuf.Manufacturer.Name.Contains(text) || comp.Name.Contains(text) || type.ServiceType.Name.Contains(text)
                         select new SearchCompanyViewModel
                         {
                             CompanyId = comp.Id,
                             Name = comp.Name,
                             Desc = comp.SmallDescription,
                             LogoUrl = comp.LogoUrl,
                             WebSiteUrl = comp.WebSiteUrl,
                             Likes = comp.Likes,
                             DisLikes = comp.Dislikes,
                             Telephone = comp.Telephones.First().Telephone
                         })
                         .Skip(index).Take(count).Distinct().ToListAsync();
            if(result == null)
            {
                return NotFound();
            }
            return result;
        }
    }
}
