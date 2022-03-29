
namespace FoodTracker_APP.Data.Entities;

public class Action
{
    public int Id { get; set; }

    [DisplayName("Action Name")]
    [Required]
    public string Name { get; set; }  
    //tem de ser ActionName ou pode ser só Name
}


/*[Required]

public List<Food> Foods { get; set; }*/