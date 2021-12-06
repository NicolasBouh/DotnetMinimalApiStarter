using DotnetMinimalApiStarter.WebApi.Common.Interfaces;
using DotnetMinimalApiStarter.WebApi.Modules.Trainings.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Trainings.Ports;

namespace DotnetMinimalApiStarter.WebApi.Modules.Trainings.Adapters
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly IRepositoryAsync<Training> _repository;

        public TrainingRepository(IRepositoryAsync<Training> repository)
        {
            _repository = repository;
        }
    }
}
