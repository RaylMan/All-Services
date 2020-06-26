using System.Collections.Generic;


namespace AllServicesData.Model
{
    public class Manufacturer : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
