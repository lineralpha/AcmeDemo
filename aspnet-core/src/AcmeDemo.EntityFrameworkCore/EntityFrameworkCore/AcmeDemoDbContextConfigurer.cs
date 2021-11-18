using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AcmeDemo.EntityFrameworkCore
{
    public static class AcmeDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AcmeDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AcmeDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
