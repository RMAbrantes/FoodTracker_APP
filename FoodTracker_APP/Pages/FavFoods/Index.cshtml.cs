namespace FoodTracker_APP.Pages.FavFoods;

public class IndexModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public IndexModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<FavFood> FavFood { get;set; }

    public async Task OnGetAsync()
    {        
        FavFood = await _context.FavFoods.ToListAsync();
    }
}
