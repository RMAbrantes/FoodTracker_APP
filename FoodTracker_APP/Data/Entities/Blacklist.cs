namespace FoodTracker_APP.Data.Entities;

public class Blacklist
{
    public int Id { get; set; }
    public Food Food { get; set; }
    public User User { get; set; }

    [Display(Name ="Date Created")]
    public DateTime DateHour { get; set; } 
}
