namespace HolidayInACity.UI.Controllers;

/// <summary>
/// public abstract class BaseController
/// </summary>
public abstract class BaseController : Controller
{
    /// <summary>
    /// private field _mediatr type ISender
    /// </summary>
    private ISender _mediatr;

    /// <summary>
    /// protected field Mediatr type ISender
    /// </summary>
    protected ISender Mediatr => _mediatr ??= HttpContext.RequestServices.GetService<ISender>();
}
