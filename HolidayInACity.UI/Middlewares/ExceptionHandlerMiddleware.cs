namespace HolidayInACity.UI.Middlewares;

/// <summary>
/// public class ExceptionHandlerMiddleware
/// this class handle errors in application
/// </summary>
public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    /// <summary>
    /// public async Task Invoke method
    /// in try block we invoke every request
    /// if any error occurs we pass it to catch block
    /// in catch block we log error message to the file
    /// and invoke HandleExceptionAsync method
    /// </summary>
    /// <param name="context"></param>
    /// <returns>HandleExceptionAsync</returns>
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next.Invoke(context);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Application Request: Nieobsłużony wyjątek - Request {Name}", context.Request.Path);

            await HandleExceptionAsync(context, exception).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// private Task HandleExceptionAsync method
    /// </summary>
    /// <param name="context"></param>
    /// <param name="exception"></param>
    /// <returns>View with information about error</returns>
    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        int statusCode = (int)HttpStatusCode.InternalServerError;
        var result = JsonConvert.SerializeObject(new
        {
            StatusCode = statusCode,
            ErrorMessage = exception.Message,
        });

        context.Response.Redirect($"{context.Request.Scheme}://{context.Request.Host}/Error");

        return context.Response.WriteAsync(result);
    }
}
