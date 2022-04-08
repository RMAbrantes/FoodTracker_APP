﻿
namespace FoodTracker_APP.Data.Entities;

public class Category
{
    public int Id { get; set; }
        
    [Required]
    [Display(Name = "Category Name")]
    public string Name { get; set; }
}
