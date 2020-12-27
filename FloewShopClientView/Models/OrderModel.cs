using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Models
{
    public class OrderModel
    {
        [Required(ErrorMessage = "*Обязательное поле")]
        [RegularExpression("[0-9]+", ErrorMessage = "Введите число")]
        public int Count { get; set; }

        [Required(ErrorMessage = "*Обязательное поле")]
        public DeliveryType DeliveryType { get; set; }
    }
}
