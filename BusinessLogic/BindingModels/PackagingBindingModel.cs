using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class PackagingBindingModel
    {
        public int? Id { get; set; }
        public string PackagingName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

    }
}
