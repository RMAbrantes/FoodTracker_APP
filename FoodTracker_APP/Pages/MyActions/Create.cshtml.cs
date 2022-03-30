namespace FoodTracker_APP.Pages.MyActions;

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
    public Action Action { get; set; }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Actions.Add(Action);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
