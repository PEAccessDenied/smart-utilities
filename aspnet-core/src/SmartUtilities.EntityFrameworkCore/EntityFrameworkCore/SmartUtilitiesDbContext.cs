using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartUtilities.Authorization.Roles;
using SmartUtilities.Authorization.Users;
using SmartUtilities.MultiTenancy;

namespace SmartUtilities.EntityFrameworkCore
{
    public class SmartUtilitiesDbContext : AbpZeroDbContext<Tenant, Role, User, SmartUtilitiesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SmartUtilitiesDbContext(DbContextOptions<SmartUtilitiesDbContext> options)
            : base(options)
        {
        }
    }
}
