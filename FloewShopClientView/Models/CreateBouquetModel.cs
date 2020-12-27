using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Models
{
    public class CreateBouquetModel
    {
        public Dictionary<int, int> FlowerBouquets { get; set; }
        public Dictionary<int, int> PackagingBouquets { get; set; }
    }
}
