namespace FoodTracker_APP.Pages.MyMeals;

public class CreateModel : PageModel
{
    private readonly FoodTrackerDbContext _context;
    

    public CreateModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        Foods = new SelectList(_context.Foods, nameof(Category.Id), nameof(Category.Name));

        Categories = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));
        return Page();
    }

    [BindProperty]
    public Meal Meal { get; set; }

    [BindProperty]
    public int[] SelectedFoods { get; set; }
    public SelectList Foods { get; set; }

    public SelectList Categories { get; set; }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        var user = _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

        Meal.User = user;

        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Meals.Add(Meal);
        await _context.SaveChangesAsync();

        //addinf foods consumed
        foreach (var item in SelectedFoods)
        {
            //TODO Quantity and QuantityType
            FoodMeal foodMeal = new FoodMeal() { MealId = Meal.Id, FoodId = item, Quantity = 0, QuantityTypes = _context.QuantityTypes.Where(x => x.Id == 1).First() };
            _context.FoodMeals.Add(foodMeal);
        }

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
