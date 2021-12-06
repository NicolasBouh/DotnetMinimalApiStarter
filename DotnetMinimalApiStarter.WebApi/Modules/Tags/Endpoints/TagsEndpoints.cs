using AutoMapper;
using DotnetMinimalApiStarter.WebApi.Common.Interfaces;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Input;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Output;
using FluentValidation;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags.Endpoints
{
    public static class TagsEndpoints
    {
        internal static async Task<List<TagOutput>> GetAll(IUnitOfWork unitOfWork, IMapper mapper)
        {
            var tags = await unitOfWork
                .Repository<Tag>()
                .GetAllAsync();

            return mapper.Map<List<TagOutput>>(tags);
        }

        internal static async Task<TagOutput?> Get(int id, IUnitOfWork unitOfWork, IMapper mapper)
        {
            var tag = await unitOfWork.
                Repository<Tag>()
                .GetByIdAsync(id);

            return mapper.Map<TagOutput>(tag);
        }

        internal static async Task<TagOutput?> Create(CreateTagInput input, IValidator<CreateTagInput> validator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            var tag = mapper.Map<Tag>(input);

            await unitOfWork
                .Repository<Tag>()
                .AddAsync(tag);
            await unitOfWork.Commit();

            return mapper.Map<TagOutput>(tag);
        }

        internal static async Task<TagOutput?> Update(int id, UpdateTagInput input, IUnitOfWork unitOfWork, IMapper mapper)
        {
            var tag = await unitOfWork
                .Repository<Tag>()
                .GetByIdAsync(id);

            tag.Name = input.Name ?? tag.Name;
            tag.Description = input.Description ?? tag.Description;

            if (tag is null)
                throw new Exception("Tag not found");

            await unitOfWork
                .Repository<Tag>()
                .UpdateAsync(tag);
            await unitOfWork.Commit();

            return mapper.Map<TagOutput>(tag);
        }

        internal static async Task<int> Delete(int id,IUnitOfWork unitOfWork)
        {
            var tag = await unitOfWork
                .Repository<Tag>()
                .GetByIdAsync(id);

            if (tag is null)
                throw new Exception("Tag not found");

            await unitOfWork
                .Repository<Tag>()
                .DeleteAsync(tag);
            await unitOfWork.Commit();

            return tag.Id;
        }
    }
}
