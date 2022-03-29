namespace FoodTracker_APP.Data.Entities;

public class FavFood
{
    public int Id { get; set; }
    public Food Food { get; set; }
    public User User { get; set; }
    public DateTime DateHour { get; set; }
}
