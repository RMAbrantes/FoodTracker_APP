namespace FoodTracker_APP.Data.Entities;

public class FavFood
{
    public int FavFoodId { get; set; }
    public int UserId { get; set; } //FK
    public int FoodId { get; set; } //FK
    public DateTime DateHour { get; set; }
}
