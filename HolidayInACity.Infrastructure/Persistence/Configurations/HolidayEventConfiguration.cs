namespace HolidayInACity.Infrastructure.Persistence.Configurations;

/// <summary>
/// configuration HolidayEvent table in database
/// </summary>
public class HolidayEventConfiguration : IEntityTypeConfiguration<HolidayEvent>
{
    public void Configure(EntityTypeBuilder<HolidayEvent> builder)
    {
        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(x => x.StartDate)
               .IsRequired();

        builder.Property(x => x.EndDate)
               .IsRequired();

        builder.Property(x => x.Description)
               .IsRequired()
               .HasMaxLength(500);

        builder.Property(x => x.Price)
               .HasPrecision(6, 2)
               .IsRequired();
    }
}
