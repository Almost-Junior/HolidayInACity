namespace HolidayInACity.Domain.Entities;

/// <summary>
/// public class EventOrganizer inherit Id from EntityBase class
/// this is table in database
/// </summary>
public class EventOrganizer : EntityBase
{
    /// <summary>
    /// public property Name type string
    /// </summary>
    public string Name { get; set; } = default!;


    /// <summary>
    /// public property EventOrganizerAddressId type int
    /// </summary>
    public int EventOrganizerAddressId { get; set; }

    /// <summary>
    /// public virtual property EventOrganizerAddress type EventOrganizerAddress
    /// </summary>
    public virtual EventOrganizerAddress EventOrganizerAddress { get; set; } = default!;

    /// <summary>
    /// public property EventOrganizerContactId type int
    /// </summary>
    public int EventOrganizerContactId { get; set; }

    /// <summary>
    /// public virtual property EventOrganizerContact type EventOrganizerContact
    /// </summary>
    public virtual EventOrganizerContact EventOrganizerContact { get; set; } = default!;

    /// <summary>
    /// public virtual property HolidayEvents type list of HolidayEvent
    /// </summary>
    public virtual ICollection<HolidayEvent> HolidayEvents { get; } = new List<HolidayEvent>();
}
