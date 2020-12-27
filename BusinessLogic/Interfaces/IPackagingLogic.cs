using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IPackagingLogic
    {
        List<PackagingViewModel> Read(PackagingBindingModel model);
        void CreateOrUpdate(PackagingBindingModel model);
        void Delete(PackagingBindingModel model);

    }
}
