using FluentValidation;

namespace DotnetMinimalApiStarter.WebApi.Modules.Tags.Input
{
    public record UpdateTagInput(string? Name, string? Description);
	public class UpdateTagInputValidator : AbstractValidator<UpdateTagInput>
	{
		public UpdateTagInputValidator()
		{
			RuleFor(x => x.Name)
				.NotNull()
				.Length(1, 100);
		}
	}
}
