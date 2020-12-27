using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class FlowerViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название цветов")]
        public string FlowerName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public int Count { get; set; }

    }
}
