namespace FoodTracker_APP.Pages.FavFoods;

public class DeleteModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DeleteModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public FavFood FavFood { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        FavFood = await _context.FavFoods.FirstOrDefaultAsync(m => m.Id == id);

        if (FavFood == null)
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

        FavFood = await _context.FavFoods.FindAsync(id);

        if (FavFood != null)
        {
            _context.FavFoods.Remove(FavFood);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
