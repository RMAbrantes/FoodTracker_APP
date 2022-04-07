namespace FoodTracker_APP.Data.Entities;

public class Food
{    
    public int Id { get; set; }
        
    [Required]
    [Display(Name = "Food Name")]
    public string Name { get; set; } 

    [Required]
    public Category Category { get; set; }     
}


