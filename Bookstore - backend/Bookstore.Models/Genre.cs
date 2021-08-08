using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Models
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<BookGenre> Books { get; set; }

    }
}
