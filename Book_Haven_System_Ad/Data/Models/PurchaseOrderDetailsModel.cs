using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Models
{
    internal class PurchaseOrderDetailsModel
    {
        public Guid PurchaseOrderDetailID { get; set; }
        public Guid PurchaseOrderID { get; set; }
        public Guid BookID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        // Navigation Properties
        public PurchaseOrderModel PurchaseOrder { get; set; }
        public BookModel Book { get; set; }
    }
}
