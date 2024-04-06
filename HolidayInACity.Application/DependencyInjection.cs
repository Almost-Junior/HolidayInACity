namespace HolidayInACity.Application;

/// <summary>
/// public static class DependencyInjection
/// in this class we inject services to application
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// static method AddApplication
    /// </summary>
    /// <param name="services"></param>
    /// <returns>services type IServiceCollection</returns>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
