using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionApp.Application.Interfaces.Repository;
using OnionApp.Persistence.Context;
using OnionApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
