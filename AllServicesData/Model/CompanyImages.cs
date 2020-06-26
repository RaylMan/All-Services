using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.Model
{
    public class CompanyImage : EntityBase
    {
        public int ImageId { get; set; }
        public int CompanyId { get; set; }
        public virtual Image  Image { get; set; }
        public virtual Company Company { get; set; }
    }
}
