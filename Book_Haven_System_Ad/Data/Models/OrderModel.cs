using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class OrderModel
    {
        public string OrderID { get; set; }  
        public Guid CustomerID { get; set; }  

        public decimal TotalAmount { get; set; }
        public string Status { get; set; }  // 'Pending', 'Shipped', 'Delivered', 'Canceled'
        public string DeliveryType { get; set; }  // 'In-Store Pickup', 'Home Delivery'
        public string DeliveryStatus { get; set; }  // 'Not Applicable', 'Processing', 'Out for Delivery', 'Delivered'
        public string DeliveryAddress { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }

        public string ProcessedBy { get; set; }

        public string OrderSource { get; set; }  // 'Online' or 'POS'

      
        public CustomerModel Customer { get; set; }  
        public List<OrderDetailsModel> OrderDetails { get; set; }
    }
}
