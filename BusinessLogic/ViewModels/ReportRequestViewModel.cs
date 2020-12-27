using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class ReportRequestViewModel
    {
        public string RequestName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> Flowers { get; set; }
    }
}
