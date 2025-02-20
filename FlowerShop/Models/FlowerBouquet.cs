﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class FlowerBouquet
    {
        public int Id { get; set; }
        public int BouquetId { get; set; }
        public int FlowerId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Flower Flower { get; set; }
        public virtual Bouquet Bouquet { get; set; }
    }
}
