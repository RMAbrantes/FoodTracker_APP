namespace FoodTracker_APP.Data.Entities;

public class Food
{
    public int FoodId { get; set; }
    public string FoodName { get; set; } //tem de ser FoodName ou pode ser só Name?
    public int CategoryId { get; set; } //FK
    
}
