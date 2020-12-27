using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
   public interface IBouquetLogic
    {
        List<BouquetViewModel> Read(BouquetBindingModel model);
        void CreateOrUpdate(BouquetBindingModel model);
        void Delete(BouquetBindingModel model);
        void DeleteFlowerBouquets(BouquetBindingModel model);
        void DeletePackagingBouquets(BouquetBindingModel model);      

    }
}
