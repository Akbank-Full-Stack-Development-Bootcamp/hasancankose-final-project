using AutoMapper;
using Bookstore.Business.DataTransferObjects;
using Bookstore.Business.Extensions;
using Bookstore.DataAccess.Repositories;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Business
{
    public class BookService : IBookService
    {
        private IBookRepository bookRepository;
        private IMapper mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.mapper = mapper;
        }

        public int AddBook(AddNewBookRequest request)
        {
            var newBook = request.ConvertToBook(mapper);
            bookRepository.Add(newBook);
            return newBook.Id;
        }

        public IList<BookListResponse> GetAllBooks()
        {
            var bookList = bookRepository.GetAll().ToList();
            var convertedBookList = bookList.ConvertToBookListResponse(mapper);
            return convertedBookList;
        }

        public BookListResponse GetBookById(int id)
        {
            Book book = bookRepository.GetById(id);
            return book.ConvertFromBookEntity(mapper);
        }

        public int UpdateBook(EditBookRequest request)
        {
            var book = request.ConvertToBookEntity(mapper);
            int id = bookRepository.Update(book).Id;
            return id;
        }
    }
}
