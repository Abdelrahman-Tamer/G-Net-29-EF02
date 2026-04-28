using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Organizer> Organizers { get; set; }
    public DbSet<OrganizerProfile> Profiles { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Attendee> Attendees { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<Registration> Registrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=ABDO;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EventConfig());
        modelBuilder.ApplyConfiguration(new RegistrationConfig());

        modelBuilder.Entity<Organizer>()
            .HasOne(o => o.Profile)
            .WithOne(p => p.Organizer)
            .HasForeignKey<OrganizerProfile>(p => p.OrganizerId);

        modelBuilder.Entity<Attendee>()
            .OwnsOne(a => a.Address);

        modelBuilder.Entity<Attendee>()
            .HasOne(a => a.Badge)
            .WithOne(b => b.Attendee)
            .HasForeignKey<Badge>(b => b.AttendeeId);
    }
}