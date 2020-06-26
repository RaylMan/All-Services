using System.ComponentModel.DataAnnotations;

namespace All_Services.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Не указан номер телефона")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указано Имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не указана Фамилия")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Не указан Адрес")]
        public string Adress { get; set; }
    }
}
