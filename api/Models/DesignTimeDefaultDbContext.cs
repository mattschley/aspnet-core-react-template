using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace aspnetCoreReactTemplate.Models
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<DefaultDbContext>
    {
        public DefaultDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                  .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();

            var options = new DbContextOptionsBuilder<DefaultDbContext>();
            options.UseSqlServer(config.GetConnectionString("defaultConnection"));

            return new DefaultDbContext(options.Options);
        }
    }
}
