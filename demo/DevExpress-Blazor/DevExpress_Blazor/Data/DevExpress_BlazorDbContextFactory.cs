using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DevExpress_Blazor.Data;

public class DevExpress_BlazorDbContextFactory : IDesignTimeDbContextFactory<DevExpress_BlazorDbContext>
{
    public DevExpress_BlazorDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DevExpress_BlazorDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new DevExpress_BlazorDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
