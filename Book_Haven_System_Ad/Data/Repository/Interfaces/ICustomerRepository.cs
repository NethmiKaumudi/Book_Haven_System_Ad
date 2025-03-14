using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Repository.Interfaces
{
    internal interface ICustomerRepository
    {

        void Add(CustomerModel customer);
        void Update(CustomerModel customer);
        void SoftDelete(Guid customerId);
        List<CustomerModel> GetAll();
        CustomerModel GetCustomerById(Guid customerId);
        
        CustomerModel GetCustomerDetailsByNumber(string customerNumber);

        int GetCustomerCount();
    }
}
