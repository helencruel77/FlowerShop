using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IFlowerLogic
    {
        List<FlowerViewModel> Read(FlowerBindingModel model);
        void CreateOrUpdate(FlowerBindingModel model);
        void Delete(FlowerBindingModel model);
        void FlowersRefill(RequestFlowersBindingModel model);
    }
}
