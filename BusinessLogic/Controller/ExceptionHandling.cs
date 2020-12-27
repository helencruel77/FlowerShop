using BusinessLogic.BindingModels;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    public class ExceptionHandling
    {
        private readonly ExceptionHandling exceptionHandling;
        public void СheckingFullness(Dictionary<int, (string, int)> dictionary, string name)
        {
            if (dictionary == null || dictionary.Count == 0)
                throw new Exception("Выберите " + name);
        }
        public  void СheckingInput(string input, string name)
        {
            if (string.IsNullOrEmpty(input))             
                throw new Exception("Заполните поле '" + name + "'");
        }
        public void CheckingSelection(Object element, string name)
        {
            if (element == null)
                throw new Exception("Выберите " + name);
        }

        public void CheckingDelivery(int index, string name)
        {
            if (index == -1)
                throw new Exception("Выберите " + name);
        }
        public static void CheckingUniqueness(Object element)
        {            
            if (element != null)           
                throw new Exception("Уже есть элемент с таким названием");         
        }
        public static void CheckingElement(Object element)
        {
            if (element == null)
                throw new Exception("Элемент не найден");
        }
        public void СheckingOrder(Object order)
        {
            if (order == null)
                throw new Exception("Не найден заказ");      
        }
        public void CheckingInputNumbers(string element)
        {
            int n;
            if (!int.TryParse(element, out n))
                throw new Exception("Неверный формат строки");
        }
       
    }
}
