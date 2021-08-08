using AutoMapper;
using Bookstore.Business.DataTransferObjects.LanguageDTO;
using Bookstore.Business.Extensions;
using Bookstore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Business
{
    public class LanguageService : ILanguageService
    {
        private ILanguageRepository languageRepository;
        private IMapper mapper;

        public LanguageService(ILanguageRepository languageRepository, IMapper mapper)
        {
            this.languageRepository = languageRepository;
            this.mapper = mapper;

        }

        public int AddLanguage(AddNewLanguageRequest request)
        {
            var newAuthor = request.ConvertToLanguage(mapper);
            languageRepository.Add(newAuthor);
            return newAuthor.Id;
        }

        public IList<LanguageListResponse> GetAllLanguages()
        {
            var dtoList = languageRepository.GetAll().ToList();
            var result = dtoList.ConvertToLanguageResponse(mapper);
            return result;
        }
    }
}
