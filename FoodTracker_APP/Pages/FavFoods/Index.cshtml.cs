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
        var user = await _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefaultAsync();
        FavFood = await _context.FavFoods.Where(b => b.User == user).ToListAsync();
    }
}
