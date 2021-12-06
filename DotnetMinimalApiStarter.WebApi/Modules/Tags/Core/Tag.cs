using DotnetMinimalApiStarter.WebApi.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Trainings.Core;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags.Core
{
    public class Tag : BaseEntity
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
