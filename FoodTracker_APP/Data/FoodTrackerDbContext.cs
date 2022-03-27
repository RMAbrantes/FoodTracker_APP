using FoodTracker_APP.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Action = System.Action;

namespace FoodTracker_APP.Data;

public class FoodTrackerDbContext : IdentityDbContext
{
    public DbSet<Action> Actions { get; set; }

    public DbSet<Blacklist> Blacklists { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<FavFood> FavFoods { get; set; }
    
    public DbSet<Food> Foods { get; set; }

    public DbSet<FoodAction> FoodActions { get; set; }

    public DbSet<FoodMeal> FoodMeals { get; set; }

    public DbSet<Meal> Meals { get; set; }
        
        
    public FoodTrackerDbContext(DbContextOptions<FoodTrackerDbContext> options)
        : base(options)
    {

    }
}
