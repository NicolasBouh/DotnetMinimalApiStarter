using DotnetMinimalApiStarter.WebApi.Core;

namespace DotnetMinimalApiStarter.WebApi.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAsync<T> Repository<T>() where T : BaseEntity;

        Task<int> Commit();

        Task<int> CommitAndRemoveCache(params string[] cacheKeys);

        Task Rollback();
    }
}
