public class Badge
{
    public int Id { get; set; }

    public string BadgeNumber { get; set; }
    public DateTime IssueDate { get; set; }

    public string Tier { get; set; }

    public int AttendeeId { get; set; }
    public Attendee Attendee { get; set; }
}