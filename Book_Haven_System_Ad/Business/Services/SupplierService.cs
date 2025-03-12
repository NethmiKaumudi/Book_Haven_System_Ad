using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Data.Repository;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Business.Services
{
    internal class SupplierService :ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService()
        {
            _supplierRepository = new SupplierRepository();
        }
        public SupplierModel GetById(Guid supplierId)
        {
            return _supplierRepository.GetById(supplierId);
        }

        public List<SupplierModel> GetAll()
        {
            return _supplierRepository.GetAll();
        }

        public void Add(SupplierModel supplier)
        {
            _supplierRepository.Add(supplier); 
        }

        public void Update(SupplierModel supplier)
        {
            _supplierRepository.Update(supplier); 
        }

        public void SoftDelete(Guid supplierId)
        {
            _supplierRepository.SoftDelete(supplierId); 
        }
    }
}
