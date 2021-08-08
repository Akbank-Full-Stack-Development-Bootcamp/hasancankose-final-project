using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Models
{
    public class Publisher : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}
