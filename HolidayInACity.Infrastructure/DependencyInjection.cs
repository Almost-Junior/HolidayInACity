namespace HolidayInACity.Infrastructure;

/// <summary>
/// public static class DependencyInjection
/// in this class we inject services to application
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// static method AddInfrastructure
    /// </summary>
    /// <param name="services"></param>
    /// <returns>services type IServiceCollection</returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }

    /// <summary>
    /// static method UseInfrastructure
    /// </summary>
    /// <param name="app"></param>
    /// <returns>app type IApplicationBuilder</returns>
    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        return app;
    }
}
