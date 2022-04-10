namespace FoodTracker_APP.Pages.MyDashboard;

public class MyDashboardModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public MyDashboardModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    [Display(Name = "Total Users")]
    public int CountUsers { get; set; }

    [Display(Name = "Total Meals")]
    public int CountMeals { get; set; }


    public IActionResult OnGet()
    {
        CountUsers = GetCountUsers();
        CountMeals = GetCountMeals();

        return Page();
    }

    private int GetCountMeals()
    {
        var meals = _context.Meals.Count(m => m.Id >= 0);
        return meals;
        
    }

    private int GetCountUsers()
    {
        var userRole = _context.Roles.FirstOrDefault(r => r.Name.Equals(Roles.BasicUser.ToString()));

        var countUsers = _context.UserRoles.Where(u => u.RoleId == userRole.Id).Count();

        return countUsers;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {

            return Page();
        }

        return RedirectToPage("./Index");
    }
}
