namespace FoodTracker_APP.Data.Entities;

public class Meal
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public User User { get; set; }  

    [Display(Name = "Start Meal")]
    [Required]
    public DateTime StartMeal { get; set; }

    [Display(Name = "End Meal")]
    [Required]
    public DateTime EndMeal { get; set; }
}
