using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AcmeDemo.Authorization.Roles;
using AcmeDemo.Authorization.Users;
using AcmeDemo.MultiTenancy;

namespace AcmeDemo.EntityFrameworkCore
{
    public class AcmeDemoDbContext : AbpZeroDbContext<Tenant, Role, User, AcmeDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AcmeDemoDbContext(DbContextOptions<AcmeDemoDbContext> options)
            : base(options)
        {
        }
    }
}
