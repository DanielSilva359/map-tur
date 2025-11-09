namespace PandaMapTur.Domain.UserItems;

public class Users
{
    public Guid Id { get; set; } = Guid.CreateVersion7(DateTime.UtcNow);
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? ProfilePicture { get; set; }
    public DateTime BirthDate { get; set; }
    public string[] TravelPreferences { get; set; } = [];
    public string? Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
