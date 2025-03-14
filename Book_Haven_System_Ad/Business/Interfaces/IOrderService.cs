using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Business.Interfaces
{
    internal interface IOrderService
    {
        void AddOrder(OrderModel order, List<OrderDetailsModel> orderDetails);
        string GenerateOrderId();
         List<OrderModel> GetAllOrders();
        void SoftDeleteOrder(string orderId);
        void EditOrder(OrderModel order);
        List<SalesReportModel> GetSalesReport(DateTime startDate, DateTime endDate, string? reportType);
         List<BestSellingBookModel> GetBestSellingBooksReport(DateTime startDate, DateTime endDate);
         List<OrderSalesData> GetSalesByProcessedBy(DateTime date);
         decimal GetTotalSalesForToday();
    }
}
