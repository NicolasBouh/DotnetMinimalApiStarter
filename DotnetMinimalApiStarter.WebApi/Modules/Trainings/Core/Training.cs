using DotnetMinimalApiStarter.WebApi.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Core;

namespace DotnetMinimalApiStarter.WebApi.Modules.Trainings.Core
{
    public class Training : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public int? Distance { get; set; }
        public int? TagId { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}
