using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RegistrationConfig : IEntityTypeConfiguration<Registration>
{
    public void Configure(EntityTypeBuilder<Registration> builder)
    {
        builder.HasKey(r => new { r.AttendeeId, r.EventId });

        builder.HasOne(r => r.Attendee)
               .WithMany(a => a.Registrations)
               .HasForeignKey(r => r.AttendeeId);

        builder.HasOne(r => r.Event)
               .WithMany(e => e.Registrations)
               .HasForeignKey(r => r.EventId);

        builder.Property(r => r.RegisteredAt)
               .HasDefaultValueSql("GETDATE()");
    }
}