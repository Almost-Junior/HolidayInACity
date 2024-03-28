namespace HolidayInACity.Domain.Entities;

/// <summary>
/// public class HolidayEvent inherit Id from EntityBase class
/// this is table in database
/// </summary>
public class HolidayEvent : EntityBase
{
    /// <summary>
    /// public property Name type string
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// public property StartDate type DateTime
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// public property EndDate type DateTime
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// public property Description type string
    /// </summary>
    public string Description { get; set; } = default!;

    /// <summary>
    /// public property Price type decimal
    /// </summary>
    public decimal Price { get; set; }


    /// <summary>
    /// public property EventOrganizerId type int
    /// </summary>
    public int EventOrganizerId { get; set; }

    /// <summary>
    /// public virtual property EventOrganizer type EventOrganizer
    /// </summary>
    public virtual EventOrganizer EventOrganizer { get; set; } = default!;
}
