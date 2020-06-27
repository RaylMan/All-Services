using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllServicesData.EF;
using AllServicesData.Model;
using System.Collections.Immutable;
using Microsoft.Data.SqlClient;

namespace All_Services.Controllers.ServicesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly AllServicesContext _context;

        public ServicesController(AllServicesContext context)
        {
            _context = context;
        }

        // GET: api/Services/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompany(int id)
        {
            //var type = await _context.ServiceTypes.FindAsync(id);
            //var companies = await _context.Companies.Include(c => c.CompanyServiceType).Where(c => c.CompanyServiceType == type).ToListAsync();
            string query = "select Companies.Id, Companies.Timestamp, Companies.User_Id, Companies.Name,Companies.Email,Companies.LogoUrl,Companies.WebSiteUrl,Companies.Description,Companies.SmallDescription,Companies.Popularity,Companies.Likes,Companies.Dislikes,Companies.AccessId from Companies inner join CompanyServiceType on Companies.Id = CompanyServiceType.Company_Id where CompanyServiceType.Service_Type_Id = @Id";
            SqlParameter param = new SqlParameter("@Id", id.ToString());

            var test = await _context.Companies.FromSqlRaw(query, param).ToListAsync();
            if (test == null)
            {
                return NotFound();
            }

            return test;
        }

    }
}
