namespace FoodTracker_APP.Data.Entities;

public class FoodAction
{
    public int FoodActionId { get; set; }

    public int ActionId { get; set; }   //FK

    public int FoodId { get; set; } //FK
    
}
