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
    internal class BookService : IBookService

    {
        private readonly IBookRepository _bookRepo;

        public BookService()
        {
            _bookRepo = new BookRepository();
        }

        public void AddBook(BookModel book)
        {
            _bookRepo.AddBook(book);
        }

        public void UpdateBook(BookModel book)
        {
            _bookRepo.UpdateBook(book);
        }

        public void DeleteBook(Guid bookID)
        {
            _bookRepo.SoftDeleteBook(bookID);
        }

        public List<BookModel> GetAllBooks()
        {
            return _bookRepo.GetAllBooks();
        }

        public BookModel GetBookById(Guid bookID)
        {
            return _bookRepo.GetBookById(bookID);
        }
        public BookModel GetBookByName(string bookName)
        {
          
            return _bookRepo.GetBookByName(bookName);  
        }

        public List<BookModel> GetLowStockBooks()
        {
            return _bookRepo.GetLowStockBooks();
        }
    }
}
