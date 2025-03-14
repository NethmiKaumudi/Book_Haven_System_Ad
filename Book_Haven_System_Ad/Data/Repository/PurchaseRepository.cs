using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Data.Models;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Repository
{
    internal class PurchaseRepository : IPurchaseOrderRepository
    {
        private readonly string connectionString = "Server=localhost;Database=bookhaven;Uid=root;Pwd=1234;";

        public bool CreatePurchaseOrder(PurchaseOrderModel order, List<PurchaseOrderDetailsModel> orderDetails)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert into purchaseorders table
                        string orderQuery = @"INSERT INTO purchaseorders (PurchaseOrderID, SupplierID, OrderDate, TotalAmount, Status) 
                                          VALUES (@PurchaseOrderID, @SupplierID, @OrderDate, @TotalAmount, @Status)";

                        using (var cmd = new MySqlCommand(orderQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PurchaseOrderID", order.PurchaseOrderID);
                            cmd.Parameters.AddWithValue("@SupplierID", order.SupplierID);
                            cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                            cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                            cmd.Parameters.AddWithValue("@Status", order.Status);
                            cmd.ExecuteNonQuery();
                        }

                        // Insert into purchaseorderdetails table
                        foreach (var detail in orderDetails)
                        {
                            string detailQuery = @"INSERT INTO purchaseorderdetails (PurchaseOrderDetailID, PurchaseOrderID, BookID, Quantity, Price) 
                                               VALUES (@PurchaseOrderDetailID, @PurchaseOrderID, @BookID, @Quantity, @Price)";

                            using (var cmd = new MySqlCommand(detailQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@PurchaseOrderDetailID", detail.PurchaseOrderDetailID);
                                cmd.Parameters.AddWithValue("@PurchaseOrderID", detail.PurchaseOrderID);
                                cmd.Parameters.AddWithValue("@BookID", detail.BookID);
                                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                                cmd.Parameters.AddWithValue("@Price", detail.Price);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public List<PurchaseOrderModel> GetAllPurchaseOrders()
        {
            var query = @"
    SELECT po.PurchaseOrderID, po.SupplierID, po.OrderDate, po.TotalAmount, po.Status, 
           pod.PurchaseOrderDetailID, pod.BookID, pod.Quantity, pod.Price
    FROM purchaseorders po
    JOIN purchaseorderdetails pod ON po.PurchaseOrderID = pod.PurchaseOrderID";

            var purchaseOrders = new List<PurchaseOrderModel>();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(query, conn);

                    using (var reader = command.ExecuteReader())
                    {
                        // This will hold the current PurchaseOrder being processed
                        PurchaseOrderModel currentPurchaseOrder = null;

                        while (reader.Read())
                        {
                            // Check if we need to create a new PurchaseOrderModel
                            var purchaseOrderID = reader.GetGuid("PurchaseOrderID");
                            if (currentPurchaseOrder == null || currentPurchaseOrder.PurchaseOrderID != purchaseOrderID)
                            {
                                // Create a new PurchaseOrderModel
                                currentPurchaseOrder = new PurchaseOrderModel
                                {
                                    PurchaseOrderID = purchaseOrderID,
                                    SupplierID = reader.GetGuid("SupplierID"),
                                    OrderDate = reader.GetDateTime("OrderDate"),
                                    TotalAmount = reader.GetDecimal("TotalAmount"),
                                    Status = reader.GetString("Status"),
                                    OrderDetails = new List<PurchaseOrderDetailsModel>()
                                };
                                purchaseOrders.Add(currentPurchaseOrder);
                            }

                            // Add PurchaseOrderDetailsModel to the current PurchaseOrder
                            currentPurchaseOrder.OrderDetails.Add(new PurchaseOrderDetailsModel
                            {
                                PurchaseOrderDetailID = reader.GetGuid("PurchaseOrderDetailID"),
                                PurchaseOrderID = purchaseOrderID,
                                BookID = reader.GetGuid("BookID"),
                                Quantity = reader.GetInt32("Quantity"),
                                Price = reader.GetDecimal("Price")
                            });
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL error: {ex.Message}");
                throw new Exception("An error occurred while retrieving purchase orders from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new Exception("An unexpected error occurred while retrieving purchase orders.", ex);
            }

            return purchaseOrders;
        }

        public bool UpdatePurchaseOrderStatus(Guid purchaseOrderID, string newStatus)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE purchaseorders 
                                       SET Status = @Status 
                                       WHERE PurchaseOrderID = @PurchaseOrderID";

                        using (var cmd = new MySqlCommand(updateQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderID);
                            cmd.Parameters.AddWithValue("@Status", newStatus);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

    }
}
