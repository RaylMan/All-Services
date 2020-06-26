using System.Collections.Generic;

namespace AllServicesData.Model
{

    public partial class Access : EntityBase
    {
        public string AccessName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
