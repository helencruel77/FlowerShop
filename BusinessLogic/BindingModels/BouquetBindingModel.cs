using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class BouquetBindingModel
    {
        public int? Id { get; set; }

        public string BouquetName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> PackagingBouquets { get; set; }
        public Dictionary<int, (string, int)> FlowerBouquets { get; set; }


    }
}