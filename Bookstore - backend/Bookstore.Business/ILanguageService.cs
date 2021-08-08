using Bookstore.Business.DataTransferObjects.LanguageDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business
{
    public interface ILanguageService
    {
        IList<LanguageListResponse> GetAllLanguages();
        int AddLanguage(AddNewLanguageRequest request);
    }
}
