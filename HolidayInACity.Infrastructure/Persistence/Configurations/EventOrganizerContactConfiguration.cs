namespace HolidayInACity.Infrastructure.Persistence.Configurations;

/// <summary>
/// configuration EventOrganizerContact table in database
/// </summary>
public class EventOrganizerContactConfiguration : IEntityTypeConfiguration<EventOrganizerContact>
{
    public void Configure(EntityTypeBuilder<EventOrganizerContact> builder)
    {
        builder.Property(x => x.PhoneNumber)
               .IsRequired()
               .HasMaxLength(20);

        builder.Property(x => x.Email)
               .IsRequired()
               .HasMaxLength(50);
    }
}