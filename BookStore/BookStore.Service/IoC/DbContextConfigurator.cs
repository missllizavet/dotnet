using BookStore.Service.Settings;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, BookStoreSettings settings)
    {
        services.AddDbContextFactory<DbContext>(
            options => { options.UseNpgsql(settings.BookStoreDbContextConnectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<DbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}