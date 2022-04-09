namespace FoodTracker_APP.Pages.MyFoods;

public class CreateModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public CreateModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        Categories = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));

        return Page();
    }

    [BindProperty]
    public Food Food { get; set; }

    public SelectList Categories { get; set; }

    [BindProperty]
    public int SelectedCategoryId { get; set; }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        if (FoodExists(Food.Name, SelectedCategoryId))
        {
            //return BadRequest($"Food {Food.Name} already exists in that category");
            return OnGet();
        }

        //link Category
        Food.Category = _context.Categories.Where(x => x.Id == SelectedCategoryId).FirstOrDefault();

        _context.Foods.Add(Food);
        await _context.SaveChangesAsync();

        //TODO não percebo pq fica inválido o Modelo...
        //if (!ModelState.IsValid)
        //{
        //    return OnGet();
        //}

        return RedirectToPage("./Index");
    }

    private bool FoodExists(string name, int categorie)
    {
        return _context.Foods.Where(x => x.Name.Equals(name) && x.Category.Id == categorie).Count() > 0;
    }
}
