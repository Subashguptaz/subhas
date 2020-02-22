using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using subhas.Authorization.Roles;
using subhas.Authorization.Users;
using subhas.MultiTenancy;

namespace subhas.EntityFrameworkCore
{
    public class subhasDbContext : AbpZeroDbContext<Tenant, Role, User, subhasDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public subhasDbContext(DbContextOptions<subhasDbContext> options)
            : base(options)
        {
        }
    }
}
