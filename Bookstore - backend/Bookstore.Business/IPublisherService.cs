using Bookstore.Business.DataTransferObjects.PublisherDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business
{
    public interface IPublisherService
    {
        IList<PublisherListResponse> GetAllPublishers();
        int AddPublisher(AddNewPublisherRequest request);
    }
}
