using System.Collections.Generic;

namespace AllServicesData.Model
{
    public partial class User : EntityBase
    {
        public int AccessId { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Token { get; set; }
        public virtual Access Access { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
