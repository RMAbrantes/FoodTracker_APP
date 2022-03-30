namespace FoodTracker_APP.Pages.MyCategories;

public class DetailsModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DetailsModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public Category Category { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);

        if (Category == null)
        {
            return NotFound();
        }
        return Page();
    }
}
