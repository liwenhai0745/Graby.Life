using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Graby.Life.Configuration;
using Graby.Life.Web;

namespace Graby.Life.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LifeDbContextFactory : IDesignTimeDbContextFactory<LifeDbContext>
    {
        public LifeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LifeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LifeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LifeConsts.ConnectionStringName));

            return new LifeDbContext(builder.Options);
        }
    }
}
