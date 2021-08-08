using Bookstore.DataAccess.Data;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.DataAccess.Repositories
{
    public class EFAuthorRepository : IAuthorRepository
    {
        private BookstoreDbContext db;

        public EFAuthorRepository(BookstoreDbContext db)
        {
            this.db = db;
        }

        public Author Add(Author entity)
        {
            db.Authors.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Author> GetAll()
        {
            return db.Authors.ToList();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Author Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
