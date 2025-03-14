using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Business.Interfaces
{
    internal interface ICustomerService
    {
        void Save(CustomerModel customer);
        void Edit(CustomerModel customer);
        void Delete(Guid customerId);
        List<CustomerModel> GetAllCustomers();
        CustomerModel GetCustomerById(Guid customerId);
        
        CustomerModel GetCustomerDetailsByNumber(string customerNumber);

         int GetCustomerCount();

    }
}
