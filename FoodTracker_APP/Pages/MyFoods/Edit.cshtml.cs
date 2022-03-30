﻿namespace FoodTracker_APP.Pages.MyFoods;

public class EditModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public EditModel(FoodTrackerDbContext context)
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

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Food).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FoodExists(Food.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool FoodExists(int id)
    {
        return _context.Foods.Any(e => e.Id == id);
    }
}
