namespace FoodTracker_APP.Data.Entities;

public class FoodAction
{
    public Action Action { get; set; }
    public Food Food { get; set; }

    public int ActionId { get; set; }   

    public int FoodId { get; set; }         
}
