namespace FoodTracker_APP.Data;

public class FoodTrackerDbContext : IdentityDbContext<User>
{    
    public DbSet<Action> Actions { get; set; }
    public DbSet<Blacklist> Blacklists { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FavFood> FavFoods { get; set; }    
    public DbSet<Food> Foods { get; set; }
    public DbSet<FoodAction> FoodActions { get; set; }
    public DbSet<FoodMeal> FoodMeals { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<QuantityType> QuantityTypes { get; set; }

    public FoodTrackerDbContext(DbContextOptions<FoodTrackerDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(50);
        modelBuilder.Entity<Action>().Property(p => p.Name).HasMaxLength(50);
        modelBuilder.Entity<Food>().Property(p => p.Name).HasMaxLength(50);
        modelBuilder.Entity<Meal>().Property(p => p.Name).HasMaxLength(50);

        modelBuilder.Entity<FoodMeal>().Property(p => p.Quantity).HasColumnType("decimal(5)");
        modelBuilder.Entity<User>().Property(p => p.Height).HasColumnType("decimal(5)");
        modelBuilder.Entity<User>().Property(p => p.Weight).HasColumnType("decimal(5)");
        modelBuilder.Entity<User>().Property(p => p.FirstName).HasMaxLength(255);
        modelBuilder.Entity<User>().Property(p => p.LastName).HasMaxLength(255);

        //FK
        modelBuilder.Entity<FoodAction>().HasKey(fa => new { fa.ActionId, fa.FoodId });
        modelBuilder.Entity<FoodMeal>().HasKey(fm => new { fm.FoodId, fm.MealId });


        modelBuilder.HasDefaultSchema("Identity");
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable(name: "User");
        });
        modelBuilder.Entity<IdentityRole>(entity =>
        {
            entity.ToTable(name: "Role");
        });
        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable("UserRoles");
        });
        modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable("UserClaims");
        });
        modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable("UserLogins");
        });
        modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
        {
            entity.ToTable("RoleClaims");
        });
        modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable("UserTokens");
        });
    }
}
