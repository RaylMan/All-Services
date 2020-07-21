using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Services.ViewModels.Company
{
    public class SearchCompanyViewModel
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string LogoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string Telephone { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
    }
}
