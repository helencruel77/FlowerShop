using BusinessLogic.BindingModels;
using BusinessLogic.Controller;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BusinessLogics
{
    public class MainLogic
    {
        private readonly IRequestLogic requestLogic;

        private readonly IOrderLogic orderLogic;
        private readonly ExceptionHandling exceptionHandling;

        public MainLogic(IOrderLogic orderLogic, IRequestLogic requestLogic, ExceptionHandling exceptionHandling)
        {
            this.orderLogic = orderLogic;
            this.requestLogic = requestLogic;
            this.exceptionHandling = exceptionHandling;

        }
        public void CreateRequest(RequestFlowersBindingModel model)
        {
            requestLogic.AddFlower(model);
        }
        public void CreateOrder(CreateOrderBindingModel model)
        {
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                BouquetId = model.BouquetId,
                ClientId = model.ClientId,
                Delivery = model.Delivery,
                Count = model.Count,
                Sum = model.Sum,
                DateCreate = DateTime.Now,
                Status = OrderStatus.Принят
            });
        }
        public void TakeOrderInWork(ChangeStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                Id = model.OrderId
            })?[0];
            exceptionHandling.СheckingOrder(order);

            if (order.Status != OrderStatus.Принят)
            {
                throw new Exception("Заказ не в статусе \"Принят\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                Id = order.Id,
                BouquetId = order.BouquetId,
                ClientId = order.ClientId,
                Count = order.Count,
                Sum = order.Sum,
                Delivery = order.Delivery,
                DateCreate = order.DateCreate,
                DateImplement = DateTime.Now,
                Status = OrderStatus.Выполняется
            });
        }
        public void FinishOrder(ChangeStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                Id = model.OrderId
            })?[0];
            exceptionHandling.СheckingOrder(order);

            if (order.Status != OrderStatus.Выполняется)
            {
                throw new Exception("Заказ не в статусе \"Выполняется\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                BouquetId = order.BouquetId,
                Count = order.Count,
                Sum = order.Sum,
                Delivery = order.Delivery,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                Status = OrderStatus.Готов
            });
        }
        public void PayOrder(ChangeStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                Id = model.OrderId
            })?[0];

            exceptionHandling.СheckingOrder(order);

            if (order.Status != OrderStatus.Готов)
            {
                throw new Exception("Заказ не в статусе \"Готов\"");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                Id = order.Id,
                BouquetId = order.BouquetId,
                ClientId = order.ClientId,
                Count = order.Count,
                Delivery = order.Delivery,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                Status = OrderStatus.Оплачен
            });
        }
    }
}
