using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int BouquetId { get; set; }

        [DisplayName("Букет")] 
        public string BouquetName { get; set; }

        [DisplayName("Id клиента")]
        public int ClientId { set; get; }

        [DisplayName("ФИО клиента")]
        public string ClientFIO { set; get; }

        [DisplayName("Количество")] 
        public int Count { get; set; }

        [DisplayName("Сумма")] 
        public decimal Sum { get; set; }

        [DisplayName("Статус")] 
        public OrderStatus Status { get; set; }

        [DisplayName("Тип доставки")]
        public DeliveryType Delivery { get; set; }

        [DisplayName("Дата создания")] 
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")] 
        public DateTime? DateImplement { get; set; }
    }
}
