using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class OrderDetailsModel
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
