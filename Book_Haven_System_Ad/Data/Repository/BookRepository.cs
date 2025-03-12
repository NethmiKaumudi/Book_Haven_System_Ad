﻿using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Repository
{
    internal class BookRepository :IBookRepository
    {
        private readonly string connectionString = "Server=localhost;Database=bookhaven;Uid=root;Pwd=1234;";

        public void AddBook(BookModel book)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO books (BookID, Title, Author, ISBN, Price, Stock, IsDeleted) VALUES (@BookID, @Title, @Author, @ISBN, @Price, @Stock, @IsDeleted)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@Title", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@ISBN", book.ISBN);
                        command.Parameters.AddWithValue("@Price", book.Price);
                        command.Parameters.AddWithValue("@Stock", book.Stock);
                        command.Parameters.AddWithValue("@IsDeleted", book.IsDeleted);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database error while adding book: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the book: " + ex.Message, ex);
            }
        }

        public void UpdateBook(BookModel book)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE books SET Title=@Title, Author=@Author, ISBN=@ISBN, Price=@Price, Stock=@Stock WHERE BookID=@BookID";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", book.BookID);
                        command.Parameters.AddWithValue("@Title", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@ISBN", book.ISBN);
                        command.Parameters.AddWithValue("@Price", book.Price);
                        command.Parameters.AddWithValue("@Stock", book.Stock);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database error while updating book: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the book: " + ex.Message, ex);
            }
        }

        public void SoftDeleteBook(Guid bookID)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE books SET IsDeleted=1 WHERE BookID=@BookID";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database error while soft deleting book: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while soft deleting the book: " + ex.Message, ex);
            }
        }

        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT BookID, Title, Author, ISBN, Price, Stock FROM Books";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add(new BookModel
                                {
                                    BookID = Guid.Parse(reader["BookID"].ToString()),
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    ISBN = reader["ISBN"].ToString(),
                                    Price = decimal.Parse(reader["Price"].ToString()),
                                    Stock = int.Parse(reader["Stock"].ToString())
                                });
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database error while retrieving all books: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving books: " + ex.Message, ex);
            }

            return books;
        }

        public BookModel GetBookById(Guid bookID)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM books WHERE BookID=@BookID AND IsDeleted=0";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookID);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BookModel
                                {
                                    BookID = Guid.Parse(reader["BookID"].ToString()),
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    ISBN = reader["ISBN"].ToString(),
                                    Price = decimal.Parse(reader["Price"].ToString()),
                                    Stock = int.Parse(reader["Stock"].ToString())
                                };
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database error while retrieving book by ID: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the book: " + ex.Message, ex);
            }

            return null;
        }

        public BookModel GetBookByName(string bookName)
{
    try
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            string query = "SELECT * FROM books WHERE Title = @Title AND IsDeleted = 0";  // Ensure the book is not deleted

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", bookName);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BookModel
                        {
                            BookID = Guid.Parse(reader["BookID"].ToString()),
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                            ISBN = reader["ISBN"].ToString(),
                            Price = decimal.Parse(reader["Price"].ToString()),
                            Stock = int.Parse(reader["Stock"].ToString())
                        };
                    }
                }
            }
        }
    }
    catch (MySqlException ex)
    {
        throw new Exception("Database error while retrieving book by title: " + ex.Message, ex);
    }
    catch (Exception ex)
    {
        throw new Exception("An error occurred while retrieving the book by title: " + ex.Message, ex);
    }

    return null;  // Return null if no book is found
}

    }
}
