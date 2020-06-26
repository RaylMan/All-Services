using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.Model
{
    public partial class CompanyAddress : EntityBase
    {
        public int CompanyId { get; set; }
        public string Address { get; set; }
        public virtual Company Company { get; set; }
    }
}
