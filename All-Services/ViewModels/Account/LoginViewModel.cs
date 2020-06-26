using System.ComponentModel.DataAnnotations;

namespace All_Services.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан номер телефона")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
