using BusinessLogic.BindingModels;
using BusinessLogic.HelperModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IRequestLogic requestLogic;
        private readonly IFlowerLogic flowerLogic;
        private readonly IOrderLogic orderLogic;
        public ReportLogic(IRequestLogic requestLogic, IFlowerLogic flowerLogic, IOrderLogic orderLogic)
        {
            this.requestLogic = requestLogic;
            this.flowerLogic = flowerLogic;
            this.orderLogic = orderLogic;
        }
        public List<ReportRequestViewModel> GetRequestPlaces()
        {
            var flowers = flowerLogic.Read(null);
            var requests = requestLogic.Read(null);
            var list = new List<ReportRequestViewModel>();
            foreach (var request in requests)
            {
                var record = new ReportRequestViewModel
                {
                    RequestName = request.RequestName,
                    Flowers = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var place in flowers)
                {
                    if (request.RequestsFlowers.ContainsKey(place.Id))
                    {
                        record.Flowers.Add(new Tuple<string, int>(place.FlowerName,
                       request.RequestsFlowers[place.Id].Item2));
                        record.TotalCount +=
                       request.RequestsFlowers[place.Id].Item2;
                    }
                }
                list.Add(record);
            }
            return list;
        }
        public List<OrderViewModel> GetOrders(int clientId)
        {
            var orders = orderLogic.Read(null);
            var list = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                if (clientId == order.ClientId)
                {
                    var record = new OrderViewModel
                    {
                        BouquetName = order.BouquetName,
                        Count = order.Count,
                        Delivery = order.Delivery,
                        Status = order.Status,
                        DateCreate = order.DateCreate,
                        Sum = order.Sum
                    };
                    list.Add(record);
                }
            }
            return list;
        }
        public void SaveRequestToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список заявок",
                RequestFlowers = GetRequestPlaces()
            });
        }
        public void SaveRequestToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список заявок",
                RequestFlowers = GetRequestPlaces()
            });
        }

        public void SaveOrdersToExcelFile(int clientId, string fileName)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = fileName,
                Title = "Список заказов",
                RequestFlowers = null,
                Orders = GetOrders(clientId)
            });
        }
    }
}
