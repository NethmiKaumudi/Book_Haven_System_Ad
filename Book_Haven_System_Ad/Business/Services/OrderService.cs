using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Data.Models;
using Book_Haven_System_Ad.Data.Repository;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Book_Haven_System_Ad.Business.Services
{
    internal class OrderService :IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public string GenerateOrderId()
        {
            string lastOrderId = _orderRepository.GetLastOrderId(); // Fetch last order ID

            int nextNumber = 1; // Default if no previous orders exist
            if (!string.IsNullOrEmpty(lastOrderId) && lastOrderId.StartsWith("OR-"))
            {
                string numberPart = lastOrderId.Substring(3); // Extract "0001"
                if (int.TryParse(numberPart, out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }

            // Return formatted Order ID
            return $"OR-{nextNumber:D4}";
        }
        public void AddOrder(OrderModel order, List<OrderDetailsModel> orderDetails)
        {
          
            _orderRepository.AddOrder(order, orderDetails); 
        }
        public  List<OrderModel> GetAllOrders()
            { return _orderRepository.GetAllOrders(); }

        public void SoftDeleteOrder(string orderId)
        {
            _orderRepository.SoftDeleteOrder(orderId);
        }

        public void EditOrder(OrderModel order)
        {
            _orderRepository.EditOrder(order);
        }
        public List<SalesReportModel> GetSalesReport(DateTime startDate, DateTime endDate, string? reportType)
        {
            return _orderRepository.GetSalesReport(startDate, endDate,reportType);
        }

        public List<BestSellingBookModel> GetBestSellingBooksReport(DateTime startDate, DateTime endDate)
        {
            return GetBestSellingBooksReport(startDate, endDate);
        }
        public List<OrderSalesData> GetSalesByProcessedBy(DateTime date)
        {
            return _orderRepository.GetSalesByProcessedBy( date);
        }
    }
}
