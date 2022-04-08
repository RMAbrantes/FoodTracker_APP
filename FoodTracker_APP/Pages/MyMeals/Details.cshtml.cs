namespace FoodTracker_APP.Pages.MyMeals;

public class DetailsModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DetailsModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public Meal Meal { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Meal = await _context.Meals.FirstOrDefaultAsync(m => m.Id == id);

        if (Meal == null)
        {
            return NotFound();
        }
        return Page();
    }
}
