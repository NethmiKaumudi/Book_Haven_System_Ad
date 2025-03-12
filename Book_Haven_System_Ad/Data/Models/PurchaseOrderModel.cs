using Book_Haven_System_Ad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class PurchaseOrderModel
    {
        public Guid PurchaseOrderID { get; set; }
        public Guid SupplierID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        // Navigation Property
        public SupplierModel Supplier { get; set; }

        // List of Purchase Order Details
        public List<PurchaseOrderDetailsModel> OrderDetails { get; set; } = new List<PurchaseOrderDetailsModel>();
    
}
}
