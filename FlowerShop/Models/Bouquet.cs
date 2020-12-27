using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class Bouquet
    {
        public int Id { get; set; }
        [Required]
        public string BouquetName { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<FlowerBouquet> FlowerBouquets { get; set; }

        public virtual List<PackagingBouquet> PackagingBouquets { get; set; }

    }
}
