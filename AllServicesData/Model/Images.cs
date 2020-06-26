using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.Model
{
    public class Image : EntityBase
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public virtual ICollection<CompanyImage> CompanyImages { get; set; }
    }
}
