using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class SupplierModel
    {
        public Guid SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public bool IsDeleted { get; set; }


        public List<BookModel> BooksSupplied { get; set; } = new List<BookModel>();

        public List<PurchaseOrderModel> PurchaseOrders { get; set; } = new List<PurchaseOrderModel>();



    }
}
