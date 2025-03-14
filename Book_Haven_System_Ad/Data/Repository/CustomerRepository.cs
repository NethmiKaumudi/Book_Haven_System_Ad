using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Repository
{
    internal class CustomerRepository :ICustomerRepository
    {
        private readonly string connectionString = "Server=localhost;Database=bookhaven;Uid=root;Pwd=1234;";

        public void Add(CustomerModel customer)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO  customers (CustomerID, Name, Email, Phone, Address, IsDeleted) VALUES (@CustomerID, @Name, @Email, @Phone, @Address, @IsDeleted)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@Name", customer.Name);
                        command.Parameters.AddWithValue("@Email", customer.Email);
                        command.Parameters.AddWithValue("@Phone", customer.Phone);
                        command.Parameters.AddWithValue("@Address", customer.Address);
                        command.Parameters.AddWithValue("@IsDeleted", customer.IsDeleted);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while adding the customer. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }
        }


        public void Update(CustomerModel customer)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE customers SET Name=@name, Email=@email, Phone=@phone, Address=@address WHERE CustomerID=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customer.CustomerID);
                        cmd.Parameters.AddWithValue("@name", customer.Name);
                        cmd.Parameters.AddWithValue("@email", customer.Email);
                        cmd.Parameters.AddWithValue("@phone", customer.Phone);
                        cmd.Parameters.AddWithValue("@address", customer.Address);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while updating the customer details.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }
        }

        public void SoftDelete(Guid customerId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE customers SET IsDeleted = 1 WHERE CustomerID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customerId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while deleting the customer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }
        }

        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT CustomerID, Name, Email, Phone, Address FROM customers WHERE IsDeleted = 0"; 

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customers.Add(new CustomerModel
                                {
                                    CustomerID = Guid.Parse(reader["CustomerID"].ToString()),
                                    Name = reader["Name"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Address = reader["Address"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while retrieving customer data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }

            return customers;
        }

        public CustomerModel GetCustomerById(Guid customerId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustomerID, Name, Email, Phone, Address FROM customers WHERE CustomerID = @id AND IsDeleted = 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customerId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new CustomerModel
                                {
                                    CustomerID = Guid.Parse(reader["CustomerID"].ToString()),
                                    Name = reader["Name"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Address = reader["Address"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while retrieving the customer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }

            return null; // Return null if no customer is found
        }
       
        public CustomerModel GetCustomerDetailsByNumber(string customerNumber)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CustomerID, Name FROM Customers WHERE Phone = @customerNumber";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerNumber", customerNumber);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CustomerModel
                            {
                                CustomerID = reader.GetGuid("CustomerID"),
                                Name = reader.GetString("Name")
                            };
                        }
                        else
                        {
                            return null; // Customer not found
                        }
                    }
                }
            }
        }
    }
}
