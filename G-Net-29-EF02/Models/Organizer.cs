using System.ComponentModel.DataAnnotations;

public class Organizer
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string? CompanyName { get; set; }

    public bool IsVerified { get; set; }

    public OrganizerProfile Profile { get; set; }

    public List<Event> Events { get; set; } = new();
}