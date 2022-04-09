namespace FoodTracker_APP.Pages.BlacklistFoods;

public class CreateModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public CreateModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {       
        return Page();
    }

    [BindProperty]
    public Blacklist Blacklist { get; set; }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        var user = _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

        Blacklist.User = user;

        if (!ModelState.IsValid)
        {
            return Page();
        }
                
        _context.Blacklists.Add(Blacklist);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
