using All_Services.EntityRequest.Admin_f.Accesses_f;
using AllServicesData.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Services.EntityRequest.Users_f
{
    public static class UsersRequests
    {
        public static async Task ChangeAccessToCompanyAsync(AllServicesContext db, int userId)
        {
            var user = await db.Users.FindAsync(userId);
            if(user !=null)
            {
                user.Access = await AccessesRequests.GetCompanyAccessAsync(db);
                await db.SaveChangesAsync();
            }
        }
        public static async Task ChangeAccessToAdminAsync(AllServicesContext db, int userId)
        {
            var user = await db.Users.FindAsync(userId);
            if (user != null)
            {
                user.Access = await AccessesRequests.GetAdminAccessAsync(db);
                await db.SaveChangesAsync();
            }
        }
        public static async Task ChangeAccessToUserAsync(AllServicesContext db, int userId)
        {
            var user = await db.Users.FindAsync(userId);
            if (user != null)
            {
                user.Access = await AccessesRequests.GetUserAccessAsync(db);
                await db.SaveChangesAsync();
            }
        }
    }
}
