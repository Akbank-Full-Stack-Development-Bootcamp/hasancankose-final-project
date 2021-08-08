using Bookstore.DataAccess.Data;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.DataAccess.Repositories
{
    public class EFLanguageRepository : ILanguageRepository
    {
        private BookstoreDbContext db;

        public EFLanguageRepository(BookstoreDbContext db)
        {
            this.db = db;
        }
        public Language Add(Language entity)
        {
            db.Languages.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Language> GetAll()
        {
            return db.Languages.ToList();
        }

        public Language GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Language Update(Language entity)
        {
            throw new NotImplementedException();
        }
    }
}
