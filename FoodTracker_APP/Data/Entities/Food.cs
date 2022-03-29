using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodTracker_APP.Data.Entities;

public class Food
{    
    public int Id { get; set; }

    [DisplayName("Food Name")]
    [Required]
    public string Name { get; set; } //tem de ser FoodName ou pode ser só Name?

    [Required]
    public Category Category { get; set; } //FK
    
}


