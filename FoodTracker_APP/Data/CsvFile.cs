namespace FoodTracker_APP.Data;

public class CsvFile
{
    private readonly FoodTrackerDbContext _context;

    public CsvFile(FoodTrackerDbContext context)
    {
        _context = context;
    }

    public void ImportCsv()
    {
        string csvpath = @"C:\Users\nuno_\source\repos\FoodTracker_APP\ETBDDb.csv";

        string[] lines = File.ReadAllLines(csvpath);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] columns = lines[i].Split(',');

            Category category;
            Action action;

            var categoryName = columns[1];

            if (!_context.Categories.Any(x => x.Name.Equals(categoryName)))
            {
                category = new Category() { Name = categoryName };

            }
            else
            {
                category = _context.Categories.FirstOrDefault(x => x.Name.Equals(categoryName));
            }

            var food = new Food() { Name = columns[0], Category = category };

            _context.Foods.Add(food);
            _context.SaveChanges();

            var actionsNames = columns[2].Trim().Split(';');

            foreach (var actionName in actionsNames)
            {

                if (!_context.Actions.Any(x => x.Name.Equals(actionName)))
                {
                    action = new Action() { Name = actionName };
                    _context.Actions.Add(action);
                    _context.SaveChanges();
                }
                else
                {
                    action = _context.Actions.FirstOrDefault(x => x.Name.Equals(actionName));
                }

                var foodAction = new FoodAction() { Action = action, Food = food, ActionId = action.Id, FoodId = food.Id };
                _context.FoodActions.Add(foodAction);
                _context.SaveChanges();
            }
        }
    }
}
