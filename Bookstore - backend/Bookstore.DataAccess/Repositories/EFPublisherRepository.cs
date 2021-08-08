using Bookstore.DataAccess.Data;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.DataAccess.Repositories
{
    public class EFPublisherRepository : IPublisherRepository
    {
        private BookstoreDbContext db;

        public EFPublisherRepository(BookstoreDbContext db)
        {
            this.db = db;
        }

        public Publisher Add(Publisher entity)
        {
            db.Publishers.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Publisher> GetAll()
        {
            return db.Publishers.ToList();
        }

        public Publisher GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Publisher Update(Publisher entity)
        {
            throw new NotImplementedException();
        }
    }
}
