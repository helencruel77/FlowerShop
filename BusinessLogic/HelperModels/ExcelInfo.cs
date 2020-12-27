using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.HelperModels
{
    public class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportRequestViewModel> RequestFlowers { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
