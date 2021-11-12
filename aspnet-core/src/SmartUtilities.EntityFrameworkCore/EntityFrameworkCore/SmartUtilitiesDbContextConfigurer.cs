using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartUtilities.EntityFrameworkCore
{
    public static class SmartUtilitiesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SmartUtilitiesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SmartUtilitiesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
