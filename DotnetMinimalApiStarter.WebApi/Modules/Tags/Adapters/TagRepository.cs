using DotnetMinimalApiStarter.WebApi.Common.Interfaces;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Ports;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags.Adapters
{
    public class TagRepository : ITagRepository
    {
        private readonly IRepositoryAsync<Tag> _repository;

        public TagRepository(IRepositoryAsync<Tag> repository)
        {
            _repository = repository;
        }
    }
}