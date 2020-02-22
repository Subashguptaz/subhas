using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using subhas.Configuration;
using subhas.Web;

namespace subhas.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class subhasDbContextFactory : IDesignTimeDbContextFactory<subhasDbContext>
    {
        public subhasDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<subhasDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            subhasDbContextConfigurer.Configure(builder, configuration.GetConnectionString(subhasConsts.ConnectionStringName));

            return new subhasDbContext(builder.Options);
        }
    }
}
