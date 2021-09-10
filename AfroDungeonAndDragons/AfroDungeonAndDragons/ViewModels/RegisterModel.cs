using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не введено имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Логин должен состоять из 2-50 символов")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
