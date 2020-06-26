namespace AllServicesData.Model
{
    public class Equipment : EntityBase
    {
        public string Model { get; set; }
        public int EquipmentTypeId { get; set; }
        public int ManufacturerId { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
