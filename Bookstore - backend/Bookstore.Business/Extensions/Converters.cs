using AutoMapper;
using Bookstore.Business.DataTransferObjects;
using Bookstore.Business.DataTransferObjects.AuthorDTO;
using Bookstore.Business.DataTransferObjects.LanguageDTO;
using Bookstore.Business.DataTransferObjects.PublisherDTO;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business.Extensions
{
    public static class Converters
    {
        public static List<BookListResponse> ConvertToBookListResponse(this List<Book> books, IMapper mapper)
        {
            return mapper.Map<List<BookListResponse>>(books);
        }
        public static Book ConvertToBook(this AddNewBookRequest request, IMapper mapper)
        {
            return mapper.Map<Book>(request);
        }
        public static BookListResponse ConvertFromBookEntity(this Book book, IMapper mapper)
        {
            return mapper.Map<BookListResponse>(book);
        }

        public static Book ConvertToBookEntity(this EditBookRequest request, IMapper mapper)
        {
            return mapper.Map<Book>(request);
        }

        public static List<AuthorListResponse> ConvertToAuthorListResponse(this List<Author> authors, IMapper mapper)
        {
            return mapper.Map<List<AuthorListResponse>>(authors);
        }

        public static Author ConvertToAuthor(this AddNewAuthorRequest request, IMapper mapper)
        {
            return mapper.Map<Author>(request);
        }

        public static List<LanguageListResponse> ConvertToLanguageResponse(this List<Language> languages, IMapper mapper)
        {
            return mapper.Map<List<LanguageListResponse>>(languages);
        }
        public static Language ConvertToLanguage(this AddNewLanguageRequest request, IMapper mapper)
        {
            return mapper.Map<Language>(request);
        }

        public static List<PublisherListResponse> ConvertToPublisherResponse(this List<Publisher> publishers, IMapper mapper)
        {
            return mapper.Map<List<PublisherListResponse>>(publishers);
        }

        public static Publisher ConvertToPublisher(this AddNewPublisherRequest request, IMapper mapper)
        {
            return mapper.Map<Publisher>(request);
        }
    }
}
