namespace DotnetMinimalApiStarter.WebApi.Modules.Trainings
{
    public class TrainingsModule : IModule
    {
        public IServiceCollection RegisterModule(IServiceCollection services)
        {
            return services;
        }

        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/trainings", () => {
                return ("Trainings");
            });
            endpoints.MapGet("/trainings/{id}", (int id) => {
                return ("Training " + id);
            });
            return endpoints;
        }
    }
}

