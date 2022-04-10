namespace FoodTracker_APP.Pages.MyActions;

public class IndexModel : PageModel
{
    private readonly FoodTrackerDbContext _context;

    public IndexModel(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public IList<Action> Action { get;set; }

    public async Task OnGetAsync()
    {
        var csvFile = new CsvFile(_context);

        csvFile.ImportCsv();

        Action = await _context.Actions.ToListAsync();
    }
}
