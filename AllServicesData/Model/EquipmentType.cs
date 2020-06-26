using System.Collections.Generic;

namespace AllServicesData.Model
{
    public class EquipmentType : EntityBase
    {
        public string Name { get; set; }
        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
