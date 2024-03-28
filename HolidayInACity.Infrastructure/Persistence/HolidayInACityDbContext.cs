namespace HolidayInACity.Infrastructure.Persistence;

public class HolidayInACityDbContext : DbContext, IHolidayInACityDbContext
{
    public HolidayInACityDbContext()
    {
    }

    public HolidayInACityDbContext(DbContextOptions<HolidayInACityDbContext> options) : base(options)
    {
    }

    public DbSet<EventOrganizer> EventOrganizers { get; set; }
    public DbSet<EventOrganizerAddress> EventOrganizerAddresses { get; set; }
    public DbSet<EventOrganizerContact> EventOrganizerContacts { get; set; }
    public DbSet<HolidayEvent> HolidayEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
