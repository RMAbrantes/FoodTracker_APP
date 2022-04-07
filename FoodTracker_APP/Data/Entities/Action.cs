namespace FoodTracker_APP.Data.Entities;

public class Action
{
    public int Id { get; set; }

    [Display(Name = "Action Name")]
    [Required]
    public string Name { get; set; }      
}

