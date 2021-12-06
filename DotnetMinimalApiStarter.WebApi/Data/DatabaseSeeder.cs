using DotnetMinimalApiStarter.WebApi.Common.Interfaces;
using DotnetMinimalApiStarter.WebApi.Modules.Tags.Core;

namespace DotnetMinimalApiStarter.WebApi.Data
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly ILogger<DatabaseSeeder> _logger;
        private readonly AppDbContext _db;

        public DatabaseSeeder(
            AppDbContext db,
            ILogger<DatabaseSeeder> logger)
        {
            _db = db;
            _logger = logger;
        }
        public void Initialize()
        {
            AddTags();

            _db.SaveChanges();
        }

        private void AddTags()
        {
            Task.Run(async () =>
            {
                if (_db.Tags.Any())
                    return;


                var tags = new Tag[]
                {
            new Tag { Name = "Endurance" },
            new Tag { Name = "Seuil" },
            new Tag { Name = "Tempo"  },
            new Tag { Name = "VMA Longue" },
            new Tag { Name = "VMA Courte" },
            new Tag { Name = "Force" }
                };

                foreach (var tag in tags)
                {
                    await _db.Tags.AddRangeAsync(tag);
                }

                _db.SaveChanges();
            }).GetAwaiter().GetResult();
        }
    }
}
