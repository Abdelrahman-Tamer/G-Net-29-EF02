using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EventConfig : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Title).IsRequired();

        builder.HasOne(e => e.Organizer)
               .WithMany(o => o.Events)
               .HasForeignKey(e => e.OrganizerId);

        builder.HasOne(e => e.ParentEvent)
               .WithMany(e => e.Sessions)
               .HasForeignKey(e => e.ParentEventId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.CreatedAt)
       .HasDefaultValueSql("GETDATE()");

        builder.Property(e => e.LastModified)
               .HasDefaultValueSql("GETDATE()");
    }
}