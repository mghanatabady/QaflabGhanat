using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QaflabGhanat.EntityFrameworkCore
{
    public static class QaflabGhanatDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QaflabGhanatDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QaflabGhanatDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
