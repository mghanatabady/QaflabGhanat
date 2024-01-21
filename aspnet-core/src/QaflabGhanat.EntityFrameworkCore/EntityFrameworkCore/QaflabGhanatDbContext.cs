using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QaflabGhanat.Authorization.Roles;
using QaflabGhanat.Authorization.Users;
using QaflabGhanat.MultiTenancy;

namespace QaflabGhanat.EntityFrameworkCore
{
    public class QaflabGhanatDbContext : AbpZeroDbContext<Tenant, Role, User, QaflabGhanatDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QaflabGhanatDbContext(DbContextOptions<QaflabGhanatDbContext> options)
            : base(options)
        {
        }
    }
}
