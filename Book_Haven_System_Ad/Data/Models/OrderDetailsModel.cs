using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class OrderDetailsModel
    {
        public Guid OrderDetailID { get; set; }
        public String OrderId { get; set; }
        public Guid BookID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public OrderModel order { get; set; }
        public BookModel Book { get; set; }
    }
}
