
namespace FoodTracker_APP.Data.Entities;

public class Category
{
    public int Id { get; set; }

    [Display(Name = "Category Name")]
    [Required]
    public string Name { get; set; }
}
