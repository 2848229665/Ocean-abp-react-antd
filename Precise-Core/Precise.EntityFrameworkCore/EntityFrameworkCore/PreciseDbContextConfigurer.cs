﻿using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Precise.EntityFrameworkCore
{
    public static class PreciseDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PreciseDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PreciseDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}