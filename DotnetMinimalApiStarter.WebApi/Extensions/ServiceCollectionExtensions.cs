using DotnetMinimalApiStarter.WebApi.Common.Interfaces;
using DotnetMinimalApiStarter.WebApi.Infrastructure;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Adapters;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Ports;
using DotnetMinimalApiStarter.WebApi.Modules.Trainings.Adapters;
using DotnetMinimalApiStarter.WebApi.Modules.Trainings.Ports;

namespace DotnetMinimalApiStarter.WebApi.Extensions
{
    public static class ServiceCollectionExtensions { 
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>))
                .AddTransient<ITrainingRepository, TrainingRepository>()
                .AddTransient<ITagRepository, TagRepository>()
                .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }       
}
