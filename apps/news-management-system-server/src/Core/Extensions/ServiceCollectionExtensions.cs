using NewsManagementSystem.APIs;

namespace NewsManagementSystem;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAdminsService, AdminsService>();
        services.AddScoped<INewsService, NewsService>();
        services.AddScoped<IUsersService, UsersService>();
        services.AddScoped<IUserTypesService, UserTypesService>();
    }
}
