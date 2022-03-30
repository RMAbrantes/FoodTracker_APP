﻿namespace FoodTracker_APP.Pages.MyFoods;

public class DeleteModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public DeleteModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Food = await _context.Foods.FindAsync(id);

        if (Food != null)
        {
            _context.Foods.Remove(Food);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
