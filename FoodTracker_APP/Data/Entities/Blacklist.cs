namespace FoodTracker_APP.Data.Entities;

public class Blacklist
{
    public int BlacklistId { get; set; }
    public int UserId { get; set; } //FK
    public int FoodId { get; set; } //FK
    public DateTime DateHour { get; set; } 
}
