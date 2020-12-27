using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class RequestFlowersBindingModel
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int FlowerId { get; set; }

        public int Count { get; set; }
    }
}
