using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Models
{
    public class RegistrationModel
    {

        [Required(ErrorMessage = "*Обязательное поле")]
        [StringLength(20, ErrorMessage = "Поле должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "*Обязательное поле")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Вы ввели некорректный E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Обязательное поле")]
        public string ClientFIO { get; set; }
    }
}