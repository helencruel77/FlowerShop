using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportRequestViewModel> RequestFlowers { get; set; }
    }
}
