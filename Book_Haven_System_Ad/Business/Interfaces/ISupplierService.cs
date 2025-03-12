using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Business.Interfaces
{
    internal interface ISupplierService
    {
       

        void Add(SupplierModel supplier);
        void Update(SupplierModel supplier);
        void SoftDelete(Guid supplierId);
        List<SupplierModel> GetAll();
        SupplierModel GetById(Guid supplierId);
    }
}
