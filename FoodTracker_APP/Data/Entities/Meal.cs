using System.ComponentModel.DataAnnotations;

namespace FoodTracker_APP.Data.Entities;

public class Meal
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public User User { get; set; }  

    [Required]
    public DateTime StartMeal { get; set; }

    [Required]
    public DateTime EndMeal { get; set; }
}
