using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Plot { get; set; }
        public int? AuthorId { get; set; }
        public int? PublisherId { get; set; }
        public int? LanguageId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Language Language { get; set; }

        public virtual IList<BookGenre> Genres { get; set; }


    }
}
