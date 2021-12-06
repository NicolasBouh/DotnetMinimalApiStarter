using DotnetMinimalApiStarter.WebApi.Modules.Tags.Core;
using DotnetMinimalApiStarter.WebApi.Modules.Trainings.Core;
using Microsoft.EntityFrameworkCore;

namespace DotnetMinimalApiStarter.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Training> Trainings { get; set; } = default!;
        public DbSet<Tag> Tags { get; set; } = default!;
    }
}
