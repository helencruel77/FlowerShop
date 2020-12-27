using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BouquetId { get; set; }
        public int ClientId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        public DeliveryType Delivery { get; set; }      
        public DateTime? DateImplement { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public virtual Bouquet Bouquet { get; set; }
        public Client Client { set; get; }

    }
}
