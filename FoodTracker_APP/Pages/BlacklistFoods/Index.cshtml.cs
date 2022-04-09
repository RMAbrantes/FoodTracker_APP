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
        var user = await _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefaultAsync();

        Blacklist = await _context.Blacklists.Where(b=> b.User == user).ToListAsync();
    }
}
