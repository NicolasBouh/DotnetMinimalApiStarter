using AutoMapper;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Input;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Output;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<CreateTagInput, Tag>();
            CreateMap<Tag, TagOutput>();
        }
    }
}
