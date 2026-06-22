using Microsoft.EntityFrameworkCore;
using SpaceObjects.Data;

namespace SpaceObjects.Tests.Infrastructure;

public static class TestDbFactory
{
    public static AppDbContext Create()
    {
        const string host = "localhost";
        const string port = "5432";
        const string db = "space_db_test";
        const string user = "postgres";
        const string password = "1234";

        const string connectionString =
            $"Host={host};Port={port};Database={db};Username={user};Password={password}";

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseNpgsql(connectionString)
            .Options;

        var context = new AppDbContext(options);

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        return context;
    }
}