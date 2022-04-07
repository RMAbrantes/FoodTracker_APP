namespace FoodTracker_APP.Data.Entities;

public class Food
{    
    public int Id { get; set; }

    [Display(Name = "Food Name")]
    [Required]
    public string Name { get; set; } 

    [Required]
    public Category Category { get; set; }     
}


