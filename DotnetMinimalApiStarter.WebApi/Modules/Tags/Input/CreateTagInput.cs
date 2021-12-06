using FluentValidation;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags.Input
{
    public record CreateTagInput(string? Name, string? Description)
	{ }
	public class CreateTagInputValidator : AbstractValidator<CreateTagInput>
	{
		public CreateTagInputValidator()
		{
			RuleFor(x => x.Name)
				.NotNull()
				.Length(1, 100);
		}
	}
}
