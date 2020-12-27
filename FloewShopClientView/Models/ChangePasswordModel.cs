using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "*Обязательное поле")]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Поле должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 6)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "*Обязательное поле")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
    }
}
