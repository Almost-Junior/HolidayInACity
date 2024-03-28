namespace HolidayInACity.Domain.Entities;

/// <summary>
/// public class EventOrganizerAddress inherit Id from EntityBase class
/// this is table in database
/// </summary>
public class EventOrganizerAddress : EntityBase
{
    /// <summary>
    /// public property Street type string
    /// </summary>
    public string Street { get; set; } = default!;

    /// <summary>
    /// public property StreetNumber type string
    /// </summary>
    public string StreetNumber { get; set; } = default!;

    /// <summary>
    /// public property PostCode type string
    /// </summary>
    public string PostCode { get; set; } = default!;

    /// <summary>
    /// public property City type string
    /// </summary>
    public string City { get; set; } = default!;


    /// <summary>
    /// public virtual property EventOrganizer type EventOrganizer
    /// </summary>
    public virtual EventOrganizer EventOrganizer { get; set; } = default!;
}
