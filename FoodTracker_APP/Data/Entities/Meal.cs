namespace FoodTracker_APP.Data.Entities;

public class Meal
{
    public int MealId { get; set; }
    public string UserID { get; set; }  //FK
    public DateTime StartMeal { get; set; }
    public DateTime EndMeal { get; set; }

}
