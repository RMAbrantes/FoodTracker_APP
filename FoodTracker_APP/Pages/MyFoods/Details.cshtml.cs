namespace FoodTracker_APP.Pages.MyFoods;

public class DetailsModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DetailsModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public Food Food { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Food = await _context.Foods.FirstOrDefaultAsync(m => m.Id == id);

        if (Food == null)
        {
            return NotFound();
        }
        return Page();
    }
}
