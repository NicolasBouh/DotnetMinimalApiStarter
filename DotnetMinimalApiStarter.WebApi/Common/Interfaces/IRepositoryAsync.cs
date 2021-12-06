using DotnetMinimalApiStarter.WebApi.Core;

namespace DotnetMinimalApiStarter.WebApi.Common.Interfaces
{
    public interface IRepositoryAsync<T> where T : BaseEntity
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<List<T>> GetPagedResponseAsync(int pageNumber, int pageSize);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
