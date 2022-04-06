namespace FoodTracker_APP.Pages.BlacklistFoods;

public class IndexModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public IndexModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<Blacklist> Blacklist { get;set; }

    public async Task OnGetAsync()
    {
        Blacklist = await _context.Blacklists.ToListAsync();
    }
}
