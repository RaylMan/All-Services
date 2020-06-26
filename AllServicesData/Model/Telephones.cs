namespace AllServicesData.Model
{
    public partial class Telephones : EntityBase
    {
        public string Telephone { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
