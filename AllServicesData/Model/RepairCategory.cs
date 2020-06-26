using System.ComponentModel.DataAnnotations;

namespace AllServicesData.Model
{
    public class RepairCategory: EntityBase
    {
        public string Name { get; set; }
        public int ServiceTypeId { get; set; }
        public string Description { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
