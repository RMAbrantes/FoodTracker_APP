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
        Meal = await _context.Meals.ToListAsync();
    }
}
