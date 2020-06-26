using AllServicesData.EF;
using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Services.EntityRequest.Admin_f.Accesses_f
{
    public static class AccessesRequests
    {
        public static async Task<Access> GetAdminAccessAsync(AllServicesContext db)
        {
            return await db.Access.FirstOrDefaultAsync(a => a.AccessName == AccessesEnum.Admin.ToString());
        }
        public static async Task<Access> GetUserAccessAsync(AllServicesContext db)
        {
            return await db.Access.FirstOrDefaultAsync(a => a.AccessName == AccessesEnum.User.ToString());
        }
        public static async Task<Access> GetCompanyAccessAsync(AllServicesContext db)
        {
            return await db.Access.FirstOrDefaultAsync(a => a.AccessName == AccessesEnum.Company.ToString());
        }
    }
}
