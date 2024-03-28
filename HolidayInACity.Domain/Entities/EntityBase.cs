namespace HolidayInACity.Domain.Entities;

/// <summary>
/// public abstract base class for all entities
/// </summary>
public abstract class EntityBase
{
    /// <summary>
    /// public property Id type int with [Key] atribute
    /// </summary>
    [Key]
    public int Id { get; set; }
}
