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
    internal class OrderRepository : IOrderRepository
    {
        private readonly string connectionString = "Server=localhost;Database=bookhaven;Uid=root;Pwd=1234;";

        
        public void AddOrder(OrderModel order, List<OrderDetailsModel> orderDetails)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    // Insert order into the orders table
                    var orderCommand = new MySqlCommand(
                        "INSERT INTO orders (OrderID, CustomerID, TotalAmount, Status, DeliveryType, DeliveryStatus, DeliveryAddress, OrderDate, ProcessedBy, IsDeleted, OrderSource) " +
                        "VALUES (@OrderID, @CustomerID, @TotalAmount, @Status, @DeliveryType, @DeliveryStatus, @DeliveryAddress, @OrderDate, @ProcessedBy, @IsDeleted, @OrderSource)",
                        connection, transaction);

                    orderCommand.Parameters.AddWithValue("@OrderID", order.OrderID);
                    orderCommand.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    orderCommand.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                    orderCommand.Parameters.AddWithValue("@Status", order.Status ?? "Pending");
                    orderCommand.Parameters.AddWithValue("@DeliveryType", order.DeliveryType);
                    orderCommand.Parameters.AddWithValue("@DeliveryStatus", order.DeliveryStatus ?? "Not Applicable");
                    orderCommand.Parameters.AddWithValue("@DeliveryAddress", order.DeliveryAddress);
                    orderCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    orderCommand.Parameters.AddWithValue("@ProcessedBy", order.ProcessedBy);
                    orderCommand.Parameters.AddWithValue("@IsDeleted", order.IsDeleted);
                    orderCommand.Parameters.AddWithValue("@OrderSource", order.OrderSource ?? "Online");

                    orderCommand.ExecuteNonQuery();

                    foreach (var orderDetail in orderDetails)
                    {
                        var orderDetailCommand = new MySqlCommand(
                            "INSERT INTO orderdetails (OrderDetailID, OrderID, BookID, Quantity, Price) " +
                            "VALUES (@OrderDetailID, @OrderID, @BookID, @Quantity, @Price)",
                            connection, transaction);

                        orderDetailCommand.Parameters.AddWithValue("@OrderDetailID", orderDetail.OrderDetailID);
                        orderDetailCommand.Parameters.AddWithValue("@OrderID", orderDetail.OrderId);
                        orderDetailCommand.Parameters.AddWithValue("@BookID", orderDetail.BookID);
                        orderDetailCommand.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                        orderDetailCommand.Parameters.AddWithValue("@Price", orderDetail.Price);

                        orderDetailCommand.ExecuteNonQuery();

                        var bookCommand = new MySqlCommand(
                            "SELECT Stock FROM books WHERE BookID = @BookID",
                            connection, transaction);
                        bookCommand.Parameters.AddWithValue("@BookID", orderDetail.BookID);

                        // Use ExecuteScalar() for efficiency
                        var stockResult = bookCommand.ExecuteScalar();
                        if (stockResult != null && stockResult != DBNull.Value)
                        {
                            var availableQuantity = Convert.ToInt32(stockResult);

                            if (availableQuantity >= orderDetail.Quantity)
                            {
                                var updateBookCommand = new MySqlCommand(
                                    "UPDATE books SET Stock = Stock - @Quantity WHERE BookID = @BookID",
                                    connection, transaction);
                                updateBookCommand.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                                updateBookCommand.Parameters.AddWithValue("@BookID", orderDetail.BookID);

                                updateBookCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show($"Not enough stock for book with ID {orderDetail.BookID}");
                                transaction.Rollback();
                                return; 
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Book with ID {orderDetail.BookID} not found.");
                            transaction.Rollback();
                            return; 
                        }
                    }

                    
                    transaction.Commit();
                    MessageBox.Show("Order added successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error saving order: {ex.Message}");
                }
            }
        }

        public string GetLastOrderId()
        {
            string lastOrderId = null;
            string query = "SELECT OrderId FROM Orders ORDER BY OrderDate DESC LIMIT 1";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        lastOrderId = result.ToString();
                    }
                }
            }
            return lastOrderId;
        }

        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orders = new List<OrderModel>();

            string query = @"
      SELECT
    o.OrderID, o.CustomerID, o.TotalAmount, o.Status,
    o.DeliveryType, o.DeliveryStatus, o.DeliveryAddress, o.OrderDate,
    o.ProcessedBy, o.IsDeleted, o.OrderSource,
    od.OrderDetailID, od.BookID, od.Quantity, od.Price
FROM orders o
LEFT JOIN orderdetails od ON o.OrderID = od.OrderID
WHERE o.IsDeleted = 0;
";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        Dictionary<string, OrderModel> orderMap = new Dictionary<string, OrderModel>();

                        while (reader.Read())
                        {
                            string orderId = reader["OrderID"].ToString();

                            if (!orderMap.ContainsKey(orderId))
                            {
                                orderMap[orderId] = new OrderModel
                                {
                                    OrderID = orderId,
                                    CustomerID = Guid.Parse(reader["CustomerID"].ToString()),
                                    TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                    Status = reader["Status"].ToString(),
                                    DeliveryType = reader["DeliveryType"].ToString(),
                                    DeliveryStatus = reader["DeliveryStatus"].ToString(),
                                    DeliveryAddress = reader["DeliveryAddress"].ToString(),
                                    OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                                    ProcessedBy = reader["ProcessedBy"].ToString(),
                                    IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                    OrderSource = reader["OrderSource"].ToString(),
                                    OrderDetails = new List<OrderDetailsModel>()
                                };
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("OrderDetailID")))
                            {
                                orderMap[orderId].OrderDetails.Add(new OrderDetailsModel
                                {
                                    OrderDetailID = Guid.Parse(reader["OrderDetailID"].ToString()),
                                    BookID = Guid.Parse(reader["BookID"].ToString()),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price = Convert.ToDecimal(reader["Price"])
                                });
                            }
                        }

                        orders = orderMap.Values.ToList();
                    }
                }
            }

            return orders;
        }
        public void SoftDeleteOrder(string orderId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE orders SET IsDeleted = 1 WHERE OrderID = @OrderID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditOrder(OrderModel order)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE orders
                              SET
                                  Status = @Status,
                                  DeliveryType = @DeliveryType,
                                  DeliveryStatus = @DeliveryStatus
                              WHERE OrderID = @OrderID";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", order.OrderID); // Assuming OrderID is a string
                        command.Parameters.AddWithValue("@Status", order.Status);
                        command.Parameters.AddWithValue("@DeliveryType", order.DeliveryType);
                        command.Parameters.AddWithValue("@DeliveryStatus", order.DeliveryStatus);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating order: " + ex.Message);
            }
        }
        public List<SalesReportModel> GetSalesReport(DateTime startDate, DateTime endDate, string? reportType)
        {
            List<SalesReportModel> salesReport = new List<SalesReportModel>();

            // Base query template
            string query = @"
        SELECT 
            ";

            // Adjust query based on the report type
            if (reportType == "Weekly")
            {
                query += @"
            YEAR(o.OrderDate) AS Year, 
            WEEK(o.OrderDate) AS Week, 
            SUM(od.Quantity * od.Price) AS TotalSales
        FROM orders o
        JOIN orderdetails od ON o.OrderID = od.OrderID
        WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
        GROUP BY YEAR(o.OrderDate), WEEK(o.OrderDate)
        ORDER BY Year, Week;
        ";
            }
            else if (reportType == "Monthly")
            {
                query += @"
            YEAR(o.OrderDate) AS Year, 
            MONTH(o.OrderDate) AS Month, 
            SUM(od.Quantity * od.Price) AS TotalSales
        FROM orders o
        JOIN orderdetails od ON o.OrderID = od.OrderID
        WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
        GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)
        ORDER BY Year, Month;
        ";
            }
            else // Default to Daily
            {
                query += @"
            o.OrderDate, 
            SUM(od.Quantity * od.Price) AS TotalSales
        FROM orders o
        JOIN orderdetails od ON o.OrderID = od.OrderID
        WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
        GROUP BY o.OrderDate
        ORDER BY o.OrderDate;
        ";
            }

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var salesModel = new SalesReportModel();

                            if (reportType == "Weekly")
                            {
                                salesModel.OrderDate = new DateTime(Convert.ToInt32(reader["Year"]), 1, 1).AddDays((Convert.ToInt32(reader["Week"]) - 1) * 7); // Calculate the date for the week
                            }
                            else if (reportType == "Monthly")
                            {
                                salesModel.OrderDate = new DateTime(Convert.ToInt32(reader["Year"]), Convert.ToInt32(reader["Month"]), 1); // Set the first day of the month
                            }
                            else
                            {
                                salesModel.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                            }

                            salesModel.TotalSales = Convert.ToDecimal(reader["TotalSales"]);
                            salesReport.Add(salesModel);
                        }
                    }
                }
            }

            return salesReport;
        }
        public List<BestSellingBookModel> GetBestSellingBooksReport(DateTime startDate, DateTime endDate)
        {
            List<BestSellingBookModel> bestSellingBooks = new List<BestSellingBookModel>();

            string query = @"
        SELECT 
            b.BookID, 
            b.Title,
            SUM(od.Quantity) AS TotalQuantitySold
        FROM orders o
        JOIN orderdetails od ON o.OrderID = od.OrderID
        JOIN books b ON od.ProductID = b.BookID
        WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
        GROUP BY b.BookID, b.Title
        ORDER BY TotalQuantitySold DESC;
    ";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bestSellingBooks.Add(new BestSellingBookModel
                            {
                                BookID = Convert.ToInt32(reader["BookID"]),
                                Title = reader["Title"].ToString(),
                                TotalQuantitySold = Convert.ToInt32(reader["TotalQuantitySold"])
                            });
                        }
                    }
                }
            }

            return bestSellingBooks;
        }
        public List<OrderSalesData> GetSalesByProcessedBy(DateTime date)
        {
            var result = new List<OrderSalesData>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT ProcessedBy, SUM(TotalAmount) AS TotalSales
            FROM orders
            WHERE IsDeleted = 0
            AND DATE(OrderDate) = @OrderDate
            GROUP BY ProcessedBy
            ORDER BY TotalSales DESC;
        ";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderDate", date.Date); 

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new OrderSalesData
                            {
                                ProcessedBy = reader["ProcessedBy"].ToString(),
                                TotalSales = Convert.ToDecimal(reader["TotalSales"])
                            });
                        }
                    }
                }
            }

            return result;
        }

        public decimal GetTotalSalesForToday()
        {
            decimal totalSales = 0;
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            string query = @"
        SELECT SUM(od.Quantity * od.Price)
        FROM orders o
        JOIN orderdetails od ON o.OrderID = od.OrderID
        WHERE o.OrderDate >= @Today AND o.OrderDate < @Tomorrow AND o.IsDeleted = 0;";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Today", today);
                    command.Parameters.AddWithValue("@Tomorrow", tomorrow);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalSales = Convert.ToDecimal(result);
                    }
                }
            }
            return totalSales;
        }
    }
}
