using AutoMapper;
using Bookstore.Business.DataTransferObjects;
using Bookstore.Business.DataTransferObjects.AuthorDTO;
using Bookstore.Business.DataTransferObjects.LanguageDTO;
using Bookstore.Business.DataTransferObjects.PublisherDTO;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListResponse>().ReverseMap();
            CreateMap<Book, AddNewBookRequest>().ReverseMap();
            CreateMap<Book, EditBookRequest>().ReverseMap();
            CreateMap<Author, AuthorListResponse>().ReverseMap();
            CreateMap<Author, AddNewAuthorRequest>().ReverseMap();
            CreateMap<Language, LanguageListResponse>().ReverseMap();
            CreateMap<Language, AddNewLanguageRequest>().ReverseMap();
            CreateMap<Publisher, PublisherListResponse>().ReverseMap();
            CreateMap<Publisher, AddNewPublisherRequest>().ReverseMap();
        }

    }
}
