using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int BouquetId { get; set; }
        public int ClientId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public DeliveryType Delivery { get; set; }

    }
}
