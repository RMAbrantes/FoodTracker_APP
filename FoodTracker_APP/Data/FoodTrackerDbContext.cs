using FoodTracker_APP.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Action = FoodTracker_APP.Data.Entities.Action;


namespace FoodTracker_APP.Data;

public class FoodTrackerDbContext : IdentityDbContext
{
    public DbSet<Action> Action { get; set; }

    public DbSet<Blacklist> Blacklist { get; set; }

    public DbSet<Category> Category { get; set; }

    public DbSet<FavFood> FavFood { get; set; }
    
    public DbSet<Food> Food { get; set; }

    public DbSet<FoodAction> FoodAction { get; set; }

    public DbSet<FoodMeal> FoodMeal { get; set; }

    public DbSet<Meal> Meal { get; set; }
            
    public FoodTrackerDbContext(DbContextOptions<FoodTrackerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
