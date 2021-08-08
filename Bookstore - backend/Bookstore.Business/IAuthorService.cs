using Bookstore.Business.DataTransferObjects.AuthorDTO;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business
{
    public interface IAuthorService
    {
        IList<AuthorListResponse> GetAllAuthors();
        int AddAuthor(AddNewAuthorRequest request);
    }
}
