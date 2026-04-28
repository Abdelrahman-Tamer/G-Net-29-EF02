public class Event
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public int MaxAttendees { get; set; }

    public int OrganizerId { get; set; }
    public Organizer Organizer { get; set; }

    public int? ParentEventId { get; set; }
    public Event ParentEvent { get; set; }

    public List<Event> Sessions { get; set; } = new();

    public List<Registration> Registrations { get; set; } = new();

    public DateTime CreatedAt { get; set; }
    public DateTime LastModified { get; set; }
}