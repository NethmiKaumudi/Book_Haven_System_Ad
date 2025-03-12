using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Repository.Interfaces
{
    internal interface IBookRepository
    {
        void AddBook(BookModel book);
        void UpdateBook(BookModel book);
        void SoftDeleteBook(Guid bookID);
        List<BookModel> GetAllBooks();
        BookModel GetBookById(Guid bookID);
        BookModel GetBookByName(string bookName);
    }
}
