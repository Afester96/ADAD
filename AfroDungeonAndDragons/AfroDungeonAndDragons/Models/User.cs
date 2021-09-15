using AfroDungeonAndDragons.Models.CharacterCreator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Не введено имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Логин должен состоять из 2-50 символов")]
        public string Login { get; set; }
       
        [Required (ErrorMessage ="Не введён Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Email { get; set; }
        
        [Required (ErrorMessage = "Не введён пароль")]
        [RegularExpression(@"^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$", ErrorMessage = "Некорректный логин")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Пароль должен состоять из 3-50 символов")]
        public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}