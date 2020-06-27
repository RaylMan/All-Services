using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.Model
{
    public class CompanyServiceType : EntityBase
    {
        public int CompanyId { get; set; }
        public int ServiceTypeId { get; set; }
        public Company Company { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
