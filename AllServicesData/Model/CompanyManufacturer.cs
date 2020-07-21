namespace AllServicesData.Model
{
    public class CompanyManufacturer : EntityBase
    {
        public int CompanyId { get; set; }
        public int ManufacturerId { get; set; }
        public Company Company { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
