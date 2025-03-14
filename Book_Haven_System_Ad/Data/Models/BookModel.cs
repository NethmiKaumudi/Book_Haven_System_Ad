using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class BookModel
    {
        public Guid BookID { get; set; }  
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }

        public Guid SupplierID { get; set; }
        public SupplierModel Supplier { get; set; }
    }
}
