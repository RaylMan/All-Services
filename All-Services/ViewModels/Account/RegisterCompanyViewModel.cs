using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace All_Services.ViewModels.Account
{
    public class RegisterCompanyViewModel
    {
        [Required(ErrorMessage = "Не указан Id пользователя владельца")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Не указано название компании")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан E-Mail компании")]
        public string Email { get; set; }
        public string LogoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Не указано краткое описание")]
        public string SmallDescription { get; set; }
        [Required(ErrorMessage = "Должен быть хотя бы один номер телефона")]
        public ICollection<string> Telephones { get; set; }
        [Required(ErrorMessage = "Должна быть хотя бы одна услуга")]
        public ICollection<int> Types { get; set; }
        public ICollection<string> Addresses { get; set; }
       
    }
}
