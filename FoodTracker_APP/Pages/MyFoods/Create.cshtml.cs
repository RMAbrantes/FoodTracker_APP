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
        Categories = new SelectList(_context.Categories, "Id", "Name");

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
        Food.Category = _context.Categories.Where(c => c.Id == SelectedCategoryId).FirstOrDefault();        
        ModelState.Clear();
        TryValidateModel(Food);
        TryValidateModel(Food.Category);

        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Foods.Add(Food);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
