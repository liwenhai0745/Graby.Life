using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Graby.Life.Authorization.Roles;
using Graby.Life.Authorization.Users;
using Graby.Life.MultiTenancy;

namespace Graby.Life.EntityFrameworkCore
{
    public class LifeDbContext : AbpZeroDbContext<Tenant, Role, User, LifeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LifeDbContext(DbContextOptions<LifeDbContext> options)
            : base(options)
        {
        }
    }
}
