using System.ComponentModel.DataAnnotations;

public class OrganizerProfile
{
    [Key]
    public int OrganizerId { get; set; }

    public string Bio { get; set; }
    public string Website { get; set; }
    public string LogoUrl { get; set; }

    public Organizer Organizer { get; set; }
}