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
    internal class SupplierRepository : ISupplierRepository

    {
        private readonly string connectionString = "Server=localhost;Database=bookhaven;Uid=root;Pwd=1234;";

        public void Add(SupplierModel supplier)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO suppliers (SupplierID, SupplierName, ContactName, ContactEmail, ContactPhone, IsDeleted) " +
                                   "VALUES (@SupplierID, @SupplierName, @ContactName, @ContactEmail, @ContactPhone, @IsDeleted)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                        command.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                        command.Parameters.AddWithValue("@ContactEmail", supplier.ContactEmail);
                        command.Parameters.AddWithValue("@ContactPhone", supplier.ContactPhone);
                        command.Parameters.AddWithValue("@IsDeleted", supplier.IsDeleted);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while adding the supplier. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }
        }

        public void Update(SupplierModel supplier)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE suppliers SET SupplierName=@SupplierName, ContactName=@ContactName, ContactEmail=@ContactEmail, " +
                                   "ContactPhone=@ContactPhone WHERE SupplierID=@SupplierID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                        cmd.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                        cmd.Parameters.AddWithValue("@ContactEmail", supplier.ContactEmail);
                        cmd.Parameters.AddWithValue("@ContactPhone", supplier.ContactPhone);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while updating the supplier details.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }
        }

        public void SoftDelete(Guid supplierId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE suppliers SET IsDeleted = 1 WHERE SupplierID = @SupplierID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while deleting the supplier.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }
        }

        public List<SupplierModel> GetAll()
        {
            List<SupplierModel> suppliers = new List<SupplierModel>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT SupplierID, SupplierName, ContactName, ContactEmail, ContactPhone FROM suppliers WHERE IsDeleted = 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                suppliers.Add(new SupplierModel
                                {
                                    SupplierID = Guid.Parse(reader["SupplierID"].ToString()),
                                    SupplierName = reader["SupplierName"].ToString(),
                                    ContactName = reader["ContactName"].ToString(),
                                    ContactEmail = reader["ContactEmail"].ToString(),
                                    ContactPhone = reader["ContactPhone"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while retrieving supplier data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }

            return suppliers;
        }

        public SupplierModel GetById(Guid supplierId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName, ContactName, ContactEmail, ContactPhone FROM suppliers WHERE SupplierID = @SupplierID AND IsDeleted = 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new SupplierModel
                                {
                                    SupplierID = Guid.Parse(reader["SupplierID"].ToString()),
                                    SupplierName = reader["SupplierName"].ToString(),
                                    ContactName = reader["ContactName"].ToString(),
                                    ContactEmail = reader["ContactEmail"].ToString(),
                                    ContactPhone = reader["ContactPhone"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                throw new Exception("An error occurred while retrieving the supplier.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw;
            }

            return null; // Return null if no supplier is found
        }
    }
}
