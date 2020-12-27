using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class BouquetViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название букета")]
        public string BouquetName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> FlowerBouquets { get; set; }
        public Dictionary<int, (string, int)> PackagingBouquets { get; set; }


    }
}
