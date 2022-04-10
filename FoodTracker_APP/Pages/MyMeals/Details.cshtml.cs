namespace FoodTracker_APP.Pages.MyMeals;

public class DetailsModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DetailsModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public Meal Meal { get; set; }

    public List<FoodMeal> FoodName { get; set; }

    public string FoodsOfTheMeal { get; set; }

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

        FoodName = await _context.FoodMeals.Include(ic => ic.Foods).Where(fa => fa.MealId == id).ToListAsync();
        FoodsOfTheMeal = String.Join(", ", FoodName.Select(x => x.Foods.Name));

        return Page();
    }
}
