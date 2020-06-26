using System.Collections.Generic;

namespace AllServicesData.Model
{
    public class ServiceType : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }
        public virtual ICollection<RepairCategory> RepairCategories { get; set; }
        public virtual ICollection<CompanyServiceTypes> CompanyServiceTypes { get; set; }
    }
}
