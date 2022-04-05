namespace FoodTracker_APP.Data.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Weight { get; set; }
    public decimal Height { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
    public int UsernameChangeLimit { get; set; } = 10;
    public byte[] ProfilePicture { get; set; }
}
