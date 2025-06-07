namespace LostAndFound.Project.Web.LostItems.Create;

public class CreateLostItemResponse(string itemName, string description, string location, DateTime lostDate, string? reward)
{
  public string ItemName { get; init; } = itemName;
  public string Description { get; set; } = description;
  public string Location { get; init; } = location;
  public DateTime LostDate { get; init; } = lostDate;
  public string Reward { get; init; } = reward!;
}
