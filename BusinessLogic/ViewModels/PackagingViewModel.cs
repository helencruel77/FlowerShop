using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class PackagingViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название упаковки")]
        public string PackagingName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public int Count { get; set; }

    }
}
