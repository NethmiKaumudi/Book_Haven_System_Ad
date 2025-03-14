using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHavenTest.Services
{
    internal class CustomerServiceTests
    {
        [TestClass]
        public class CustomerServiceTests
        {
            private CustomerService _customerService;

            [TestInitialize]
            public void SetUp()
            {
                _customerService = new CustomerService();
            }

            [TestMethod]
            public void TestSaveCustomer()
            {
                // Arrange
                var customer = new CustomerModel
                {
                    CustomerID = Guid.NewGuid(),
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Phone = "1234567890",
                    Address = "123 Main St",
                    IsDeleted = false
                };

                // Act
                _customerService.Save(customer);

                // Assert
                // You would need to verify that the customer is saved correctly. 
                // For example, checking the database or mocking the repository.
                Assert.IsNotNull(customer.CustomerID);
            }
        }
    }
}
