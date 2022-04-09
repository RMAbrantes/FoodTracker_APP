namespace FoodTracker_APP.Data.Entities;

public class FoodMeal
{
    public Food Foods { get; set; }
    public Meal Meals { get; set; }

    public int FoodId { get; set; } 

    public int MealId { get; set; } 

    [Required]
    public QuantityType QuantityTypes { get; set; }

    [Required]
    public decimal Quantity { get; set; } //quantity ou Portion?

}


