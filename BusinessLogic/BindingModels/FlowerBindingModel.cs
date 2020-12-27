using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class FlowerBindingModel
    {
        public int? Id { get; set; }
        public string FlowerName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

    }
}
