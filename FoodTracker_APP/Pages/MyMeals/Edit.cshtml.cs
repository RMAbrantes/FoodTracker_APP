namespace FoodTracker_APP.Pages.MyMeals;

public class EditModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public EditModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Meal Meal { get; set; }

    [BindProperty]
    public int[] SelectedFoods { get; set; }

    public SelectList Foods { get; set; }

    public SelectList Categories { get; set; }

    public List<FoodMeal> FoodName { get; set; }

    public string FoodsOfTheMeal { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        Foods = new SelectList(_context.Foods, nameof(Category.Id), nameof(Category.Name));

        Categories = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));

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

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        var user = _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

        Meal.User = user;

        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Meal).State = EntityState.Modified;

        /*try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MealExists(Meal.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }*/

       
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

    private bool MealExists(int id)
    {
        return _context.Meals.Any(e => e.Id == id);
    }
}
