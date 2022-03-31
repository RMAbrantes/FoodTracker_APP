namespace FoodTracker_APP.Pages.MyFoods;

public class IndexModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public IndexModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<Food> Food { get;set; }

    public async Task OnGetAsync()
    {
        var csvFile = new CsvFile(_context);

        csvFile.ImportCsv();

        Food = await _context.Foods.ToListAsync();
        //.Include(f => f.Category)
    }
}
