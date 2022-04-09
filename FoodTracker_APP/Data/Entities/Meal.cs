namespace FoodTracker_APP.Data.Entities;

public class Meal
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public User User { get; set; }  
        
    [Required]
    [Display(Name = "Start Meal")]
    public DateTime StartMeal { get; set; } 
        
    [Required]
    [Display(Name = "End Meal")]
    public DateTime EndMeal { get; set; }

    public FoodMeal[] Foodmeals { get; set; }
   
}
