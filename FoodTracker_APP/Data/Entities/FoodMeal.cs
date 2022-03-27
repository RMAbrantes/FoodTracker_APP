namespace FoodTracker_APP.Data.Entities;

public class FoodMeal
{
    public int FoodMealId { get; set; }
    public int FoodId { get; set; } //FK

    public int MealId { get; set; } //FK

    public decimal FoodQuantity { get; set; } //quantity ou Portion?

}
