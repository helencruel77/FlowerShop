﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.Models
{
    public class Flower
    {
        public int Id { get; set; }
        [Required]
        public string FlowerName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Count { get; set; }

        [ForeignKey("FlowerId")]
        public virtual List<RequestFlowers> RequestPackagingFlowers { get; set; }

        [ForeignKey("FlowerId")]
        public virtual List<FlowerBouquet> FlowerBouquet { get; set; }

    }
}
