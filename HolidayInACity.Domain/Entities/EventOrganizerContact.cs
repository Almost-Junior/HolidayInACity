namespace HolidayInACity.Domain.Entities;

/// <summary>
/// public class EventOrganizerContact inherit Id from EntityBase class
/// this is table in database
/// </summary>
public class EventOrganizerContact : EntityBase
{
    /// <summary>
    /// public property PhoneNumber type string
    /// </summary>
    public string PhoneNumber { get; set; } = default!;

    /// <summary>
    /// public property Email type string
    /// </summary>
    public string Email { get; set; } = default!;

    /// <summary>
    /// public virtual property EventOrganizer type EventOrganizer
    /// </summary>
    public virtual EventOrganizer EventOrganizer { get; set; } = default!;
}
