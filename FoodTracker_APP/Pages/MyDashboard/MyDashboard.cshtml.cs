namespace FoodTracker_APP.Pages.MyDashboard;

public class MyDashboardModel : PageModel
{
	private readonly FoodTrackerDbContext _context;

	public MyDashboardModel(FoodTrackerDbContext context)
	{
		_context = context;
	}

	[Display(Name = "TOP 5 Active Users")]
	public IEnumerable<string> TOPActiveUsers { get; set; }

	[Display(Name = "Total Meals")]
	public int CountMeals { get; set; }

	[Display(Name = "TOP 10")]
	public IEnumerable<string> TOPFoods { get; set; }


	public IActionResult OnGet()
	{
		TOPActiveUsers = GetTopActiveUsers();
		TOPFoods = GetTopFood();
		CountMeals = GetCountMeals();

		return Page();
	}

	private IEnumerable<string> GetTopActiveUsers()
	{
		var activeUserValue = 5;
		var topActive = _context.Meals.GroupBy(ta => ta.User.Id).OrderByDescending(ta => ta.Count()).Take(activeUserValue);
		var activeName = String.Join(" | ", topActive.Select(an => an.First().User.Email));

		yield return activeName;
	}

	private IEnumerable<string> GetTopFood()
	{
		var value = 10;
		
		var topFood = _context.FoodMeals.GroupBy(t => t.FoodId).OrderByDescending(t => t.Count()).Take(value);

		var name = String.Join(" | ", topFood.Select(n => n.First().Foods.Name));
		yield return name;
	}

	private int GetCountMeals()
	{
		var meals = _context.Meals.Count(m => m.Id >= 0);
		return meals;
		
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
