using AutoMapper;
using Bookstore.Business.DataTransferObjects;
using Bookstore.Business.DataTransferObjects.AuthorDTO;
using Bookstore.Business.Extensions;
using Bookstore.DataAccess.Repositories;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Business
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository authorRepository;
        private IMapper mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            this.authorRepository = authorRepository;
            this.mapper = mapper;

        }

        public int AddAuthor(AddNewAuthorRequest request)
        {
            var newAuthor = request.ConvertToAuthor(mapper);
            authorRepository.Add(newAuthor);
            return newAuthor.Id;
        }

        public IList<AuthorListResponse> GetAllAuthors()
        {
            var dtoList = authorRepository.GetAll().ToList();
            var result = dtoList.ConvertToAuthorListResponse(mapper);
            return result;
        }
    }
}
