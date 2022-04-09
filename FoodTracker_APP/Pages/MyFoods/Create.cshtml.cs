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
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Foods.Add(Food);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
