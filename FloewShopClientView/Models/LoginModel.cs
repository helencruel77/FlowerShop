using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "*Обязательное поле")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Обязательное поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
