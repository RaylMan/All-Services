using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.Model
{
    public class CompanyServiceTypes: EntityBase
    {
        public int CompanyId { get; set; }
        public int ServiceTypeId { get; set; }
        public Company Company { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
