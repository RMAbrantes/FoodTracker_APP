namespace FoodTracker_APP.Pages.MyCategories;

public class IndexModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public IndexModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<Category> Category { get;set; }

    public async Task OnGetAsync()
    {
        Category = await _context.Categories.ToListAsync();
    }
}
