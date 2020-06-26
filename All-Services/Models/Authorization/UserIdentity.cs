using AllServicesData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace All_Services.Models.Authorization
{
    public class UserIdentity
    {
        public User User { get; set; }
        public ClaimsIdentity ClaimsIdentity { get; set; }
        public UserIdentity(User user, ClaimsIdentity claimsIdentity)
        {
            User = user;
            ClaimsIdentity = claimsIdentity;
        }
    }
}
