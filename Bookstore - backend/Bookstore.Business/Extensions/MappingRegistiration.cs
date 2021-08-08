using Bookstore.Business.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Business.Extensions
{
    public static class MappingRegistiration
    {
        public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
