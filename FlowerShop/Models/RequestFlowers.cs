using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class RequestFlowers
    {
        public int Id { get; set; }

        public int RequestId { get; set; }
        public int FlowerId { get; set; }

        [Required]
        public int Count { get; set; }

        public virtual Request Request { get; set; }
        public virtual Flower Flower { get; set; }
    }
}
