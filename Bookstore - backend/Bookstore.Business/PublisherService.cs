using AutoMapper;
using Bookstore.Business.DataTransferObjects.PublisherDTO;
using Bookstore.Business.Extensions;
using Bookstore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Business
{
    public class PublisherService : IPublisherService
    {
        private IPublisherRepository publisherRepository;
        private IMapper mapper;

        public PublisherService(IPublisherRepository publisherRepository, IMapper mapper)
        {
            this.publisherRepository = publisherRepository;
            this.mapper = mapper;
        }

        public int AddPublisher(AddNewPublisherRequest request)
        {
            var newPublisher = request.ConvertToPublisher(mapper);
            publisherRepository.Add(newPublisher);
            return newPublisher.Id;
        }

        public IList<PublisherListResponse> GetAllPublishers()
        {
            var dtoList = publisherRepository.GetAll().ToList();
            var result = dtoList.ConvertToPublisherResponse(mapper);
            return result;
        }
    }
}
