namespace FoodTracker_APP.Pages.BlacklistFoods;

public class DeleteModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DeleteModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Blacklist Blacklist { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Blacklist = await _context.Blacklists.FirstOrDefaultAsync(m => m.Id == id);

        if (Blacklist == null)
        {
            return NotFound();
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Blacklist = await _context.Blacklists.FindAsync(id);

        if (Blacklist != null)
        {
            _context.Blacklists.Remove(Blacklist);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
