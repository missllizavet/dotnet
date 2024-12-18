using BookStore.Service.Settings;
using Microsoft.EntityFrameworkCore;
using BookStore.DataAccess;

namespace BookStore.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, BookStoreSettings settings)
    {
        services.AddDbContextFactory<BookStoreDbContext>(
            options => { options.UseNpgsql(settings.BookStoreDbContextConnectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<BookStoreDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}