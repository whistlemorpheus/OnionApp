using OnionApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionApp.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task<T> AddAsync(T entity);
    }
}
