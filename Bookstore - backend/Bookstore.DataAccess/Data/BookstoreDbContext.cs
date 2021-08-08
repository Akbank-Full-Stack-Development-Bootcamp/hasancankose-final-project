using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.DataAccess.Data
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public BookstoreDbContext()
        {

        }

        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                        .HasOne(book => book.Author)
                        .WithMany(author => author.Books)
                        .HasForeignKey(book => book.AuthorId);

            modelBuilder.Entity<Book>()
                        .HasOne(book => book.Language)
                        .WithMany(language => language.Books)
                        .HasForeignKey(book => book.LanguageId);

            modelBuilder.Entity<Book>()
                        .HasOne(book => book.Publisher)
                        .WithMany(publisher => publisher.Books)
                        .HasForeignKey(book => book.PublisherId);

            modelBuilder.Entity<BookGenre>()
                        .HasKey(mg => new { mg.BookId, mg.GenreId });

            modelBuilder.Entity<BookGenre>()
                        .HasOne(mg => mg.Book)
                        .WithMany(book => book.Genres)
                        .HasForeignKey(mg => mg.GenreId);

            modelBuilder.Entity<BookGenre>()
                        .HasOne(mg => mg.Genre)
                        .WithMany(genre => genre.Books)
                        .HasForeignKey(mg => mg.BookId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
