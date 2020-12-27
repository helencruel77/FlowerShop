using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class PackagingBouquet
    {
        public int Id { get; set; }
        public int BouquetId { get; set; }
        public int PackagingId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Packaging Packaging { get; set; }
        public virtual Bouquet Bouquet { get; set; }
    }
}
