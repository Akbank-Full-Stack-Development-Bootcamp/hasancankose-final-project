using Bookstore.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business
{
    public interface IBookService
    {
        IList<BookListResponse> GetAllBooks();
        int AddBook(AddNewBookRequest request);

        BookListResponse GetBookById(int id);

        int UpdateBook(EditBookRequest request);
    }
}
