using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodTracker_APP.Data.Entities;

public class Category
{
    public int Id { get; set; }

    [DisplayName("Category Name")]
    [Required]
    public string Name { get; set; }
}
