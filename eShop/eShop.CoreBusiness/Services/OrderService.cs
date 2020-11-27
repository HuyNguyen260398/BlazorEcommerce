using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.CoreBusiness.Services
{
    public class OrderService : IOrderService
    {
        public bool ValidateCustomerInformation(
            string name,
            string address,
            string city,
            string province,
            string country)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(province) ||
                string.IsNullOrWhiteSpace(country)) return false;

            return true;
        }

        public bool ValidateCreateOrder(Order order)
        {
            if (order == null) return false;

            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 ||
                    item.Price < 0 ||
                    item.Quantity <= 0) return false;
            }

            if (!ValidateCustomerInformation(order.CustomerName,
                                             order.CustomerAddress,
                                             order.CustomerCity,
                                             order.CustomerStateProvince,
                                             order.CustomerCountry)) return false;
            return true;
        }

        public bool ValidateUpdateOrer(Order order)
        {
            if (order == null) return false;
            if (!order.OrderId.HasValue) return false;

            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            if (!order.DatePlaced.HasValue) return false;

            if (order.DateProcessed.HasValue || order.DateProcessing.HasValue) return false;

            if (string.IsNullOrWhiteSpace(order.UniqueId)) return false;

            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 ||
                    item.Price < 0 ||
                    item.Quantity <= 0 ||
                    item.OrderId == order.OrderId) return false;
            }

            if (!ValidateCustomerInformation(order.CustomerName,
                                             order.CustomerAddress,
                                             order.CustomerCity,
                                             order.CustomerStateProvince,
                                             order.CustomerCountry)) return false;
            return true;
        }

        public bool ValidateProcessOrder(Order order)
        {
            if (!order.DateProcessed.HasValue ||
                string.IsNullOrWhiteSpace(order.AdminUser)) return false;

            return true;
        }
    }
}
