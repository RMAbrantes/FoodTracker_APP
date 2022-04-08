namespace FoodTracker_APP.Pages.FavFoods;

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
    public FavFood FavFood { get; set; }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        var user = _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

        FavFood.User = user;

        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.FavFoods.Add(FavFood);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
