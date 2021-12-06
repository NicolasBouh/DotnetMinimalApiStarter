using DotnetMinimalApiStarter.WebApi.Extensions;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Endpoints;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Input;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags
{
    public class TagsModule : IModule
    {
        public IServiceCollection RegisterModule(IServiceCollection services)
        {
            return services;
        }

        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/tags", TagsEndpoints.GetAll);
            endpoints.MapGet("/tags/{id}", TagsEndpoints.Get);
            endpoints.MapPost("/tags", TagsEndpoints.Create)
                .WithValidator<CreateTagInput>();
            endpoints.MapPut("/tags/{id}", TagsEndpoints.Update)
                .WithValidator<UpdateTagInput>(); ;
            endpoints.MapDelete("/tags/{id}", TagsEndpoints.Delete);

            return endpoints;
        }
    }
}
