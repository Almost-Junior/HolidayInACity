namespace HolidayInACity.Application.Common.Interfaces;

public interface IHolidayInACityDbContext : IDisposable
{
    DbSet<EventOrganizer> EventOrganizers { get; set; }
    DbSet<EventOrganizerAddress> EventOrganizerAddresses { get; set; }
    DbSet<EventOrganizerContact> EventOrganizerContacts { get; set; }
    DbSet<HolidayEvent> HolidayEvents { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
