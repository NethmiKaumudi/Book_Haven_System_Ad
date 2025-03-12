using System;
using System.Data;
using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Book_Haven__Application.Data.Repository
{
    internal class UserRepository :IUserRepository
    {
        private readonly string connectionString = "Server=localhost;Database=bookhaven;Uid=root;Pwd=1234;";

        public UserRepository()
        {
        }

        public void AddUser(UserModel user)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (UserID, Username, Password, Role, DateCreated, IsDeleted) VALUES (@UserID, @Username, @Password, @Role, @DateCreated, @IsDeleted)";

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", user.UserID);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.PasswordHash);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@DateCreated", user.DateCreated);
                    command.Parameters.AddWithValue("@IsDeleted", user.IsDeleted);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Log or handle exception (e.g., duplicate username, connection issues)
                    Console.WriteLine($"Error in AddUser: {ex.Message}");
                    // Log the stack trace for more details (optional)
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public UserModel GetUserByUsername(string username)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @Username AND IsDeleted = 0";

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new UserModel
                        {
                            UserID = Guid.Parse(reader["UserID"].ToString()),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["Password"].ToString(),
                            Role = reader["Role"].ToString(),
                            DateCreated = DateTime.Parse(reader["DateCreated"].ToString()),
                            IsDeleted = Convert.ToBoolean(reader["IsDeleted"])
                        };
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    // Log or handle exception (e.g., invalid username, connection issues)
                    Console.WriteLine($"Error in GetUserByUsername: {ex.Message}");
                    Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT UserID, Username, Role FROM Users WHERE IsDeleted = 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new UserModel
                                {
                                    UserID = Guid.Parse(reader["UserID"].ToString()),
                                    Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle exception (e.g., connection issues, query issues)
                    Console.WriteLine($"Error in GetAllUsers: {ex.Message}");
                    Console.WriteLine(ex.StackTrace);
                }
            }

            return users;
        }

        public void SoftDeleteUser(string username)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET IsDeleted = 1 WHERE Username = @Username";

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Log or handle exception (e.g., user not found, connection issues)
                    Console.WriteLine($"Error in SoftDeleteUser: {ex.Message}");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public void UpdateUserByUsername(string username, string passwordHash, string role)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    List<string> updates = new List<string>();
                    var command = new MySqlCommand
                    {
                        Connection = connection
                    };

                    if (!string.IsNullOrEmpty(passwordHash))
                    {
                        updates.Add("Password = @Password");
                        command.Parameters.AddWithValue("@Password", passwordHash);
                    }
                    if (!string.IsNullOrEmpty(role))
                    {
                        updates.Add("Role = @Role");
                        command.Parameters.AddWithValue("@Role", role);
                    }

                    if (updates.Count == 0)
                    {
                        Console.WriteLine("No fields to update.");
                        return;
                    }

                    string query = $"UPDATE Users SET {string.Join(", ", updates)} WHERE Username = @Username";
                    command.Parameters.AddWithValue("@Username", username);
                    command.CommandText = query;

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Log or handle exception (e.g., invalid input, connection issues)
                    Console.WriteLine($"Error in UpdateUserByUsername: {ex.Message}");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

    }
}
