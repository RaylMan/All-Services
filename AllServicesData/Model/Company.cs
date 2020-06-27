using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.Model
{
    public partial class Company : EntityBase
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LogoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public int Popularity { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Telephones> Telephones { get; set; }
        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
        public virtual ICollection<CompanyImage> CompanyImages { get; set; }
        public virtual ICollection<CompanyServiceType> CompanyServiceType { get; set; }
    }
}
