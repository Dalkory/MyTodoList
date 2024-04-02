using System.ComponentModel.DataAnnotations;

namespace MyTodoList.Models.Account
{
    public class AccountViewModel
    {
        public LoginViewModel ?LoginViewModel { get; set; }

        public RegisterViewModel ?RegisterViewModel { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Данное поле обяхательно")]
        public string ?Login { get; set; }

        [Required(ErrorMessage = "Данное поле обяхательно")]
        public string ?Password { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Данное поле обяхательно")]
        public string ?Login { get; set; }

        [Required(ErrorMessage = "Данное поле обяхательно")]
        public string ?Password { get; set; }

        [Required(ErrorMessage = "Данное поле обяхательно")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ?RepeatPassword { get; set; }
    }
}
