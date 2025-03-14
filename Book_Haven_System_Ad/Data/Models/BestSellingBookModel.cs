using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Models
{
    internal class BestSellingBookModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int TotalQuantitySold { get; set; }
    }
}
