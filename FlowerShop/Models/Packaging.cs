using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.Models
{
   public class Packaging
    {
        public int Id { get; set; }
     
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string PackagingName { get; set; }
        public int Count { get; set; }

        [ForeignKey("PackagingId")]
        public virtual List<PackagingBouquet> PackagingBouquet { get; set; }

    }
}
