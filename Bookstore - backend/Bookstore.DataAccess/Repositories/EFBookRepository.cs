using Bookstore.DataAccess.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.DataAccess.Repositories
{
    public class EFBookRepository : IBookRepository
    {

        private BookstoreDbContext db;

        public EFBookRepository(BookstoreDbContext bookstoreDbContext)
        {
            db = bookstoreDbContext;
        }

        public Book Add(Book entity)
        {
            db.Books.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public Book GetById(int id)
        {
            return db.Books.AsNoTracking().FirstOrDefault(book => book.Id == id);
        }

        public Book Update(Book book)
        {
            db.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return book;
        }
    }
}
