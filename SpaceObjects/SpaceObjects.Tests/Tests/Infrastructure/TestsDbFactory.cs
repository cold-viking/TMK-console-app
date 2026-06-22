using Microsoft.EntityFrameworkCore;
using SpaceObjects.Data;

namespace SpaceObjects.Tests.Infrastructure;

public static class TestDbFactory
{
    public static AppDbContext Create()
    {
        DotNetEnv.Env.Load();

        var host = Environment.GetEnvironmentVariable("POSTGRES_HOST");
        var port = Environment.GetEnvironmentVariable("POSTGRES_PORT");
        var db = "space_db_test";
        var user = Environment.GetEnvironmentVariable("POSTGRES_USER");
        var password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");

        var connectionString =
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