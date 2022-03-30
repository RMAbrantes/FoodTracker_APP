namespace FoodTracker_APP.Pages.MyCategories;

public class IndexModel : PageModel
{
    private readonly FoodTracker_APP.Data.FoodTrackerDbContext _context;

    public IndexModel(FoodTracker_APP.Data.FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<Category> Category { get;set; }

    public async Task OnGetAsync()
    {
        Category = await _context.Categories.ToListAsync();
    }
}
