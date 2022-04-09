namespace FoodTracker_APP.Pages.MyMeals;

public class IndexModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public IndexModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<Meal> Meal { get;set; }

    public async Task OnGetAsync()
    {
        var user = await _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefaultAsync();

        Meal = await _context.Meals.Where(m => m.User == user).ToListAsync();
    }
}
