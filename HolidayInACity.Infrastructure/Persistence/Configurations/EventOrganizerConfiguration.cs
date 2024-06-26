﻿namespace HolidayInACity.Infrastructure.Persistence.Configurations;

/// <summary>
/// configuration EventOrganizer table in database
/// </summary>
public class EventOrganizerConfiguration : IEntityTypeConfiguration<EventOrganizer>
{
    public void Configure(EntityTypeBuilder<EventOrganizer> builder)
    {
        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(200);

        builder.HasMany(x => x.HolidayEvents)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey(z => z.EventOrganizerId)
               .IsRequired();

        builder.HasOne(x => x.EventOrganizerAddress)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey<EventOrganizerAddress>(z => z.Id)
               .IsRequired();

        builder.HasOne(x => x.EventOrganizerContact)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey<EventOrganizerContact>(z => z.Id)
               .IsRequired();
    }
}
