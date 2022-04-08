namespace FoodTracker_APP.Data.Entities;

public class Action
{
    public int Id { get; set; }
        
    [Required]
    [Display(Name = "Action Name")]
    public string Name { get; set; }      
}

