using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace subhas.EntityFrameworkCore
{
    public static class subhasDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<subhasDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<subhasDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
