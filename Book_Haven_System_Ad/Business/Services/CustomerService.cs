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
    internal class CustomerService :ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerService()
        {
            _customerRepo = new CustomerRepository();
        }

        public void Save(CustomerModel customer)
        {
            _customerRepo.Add(customer);
        }

        public void Edit(CustomerModel customer)
        {
            _customerRepo.Update(customer);
        }

        public void Delete(Guid customerId)
        {
            _customerRepo.SoftDelete(customerId);
        }

        public List<CustomerModel> GetAllCustomers()
        {
            return _customerRepo.GetAll();
        }
        public CustomerModel GetCustomerById(Guid customerId)
        {
            var customer = _customerRepo.GetCustomerById(customerId);

            if (customer == null)
            {
                throw new Exception("Customer not found.");
            }

            return customer;
        }
        public CustomerModel GetCustomerDetailsByNumber(string customerNumber)
        {
            return _customerRepo.GetCustomerDetailsByNumber(customerNumber);
        }
        public int GetCustomerCount()
        {
            return _customerRepo.GetCustomerCount();    
        }
    }
}
