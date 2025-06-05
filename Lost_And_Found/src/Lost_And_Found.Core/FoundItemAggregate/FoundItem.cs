using LostAndFound.Project.Core.MatchAggregate;
using LostAndFound.Project.Core.ReportAggregate;
using LostAndFound.Project.Core.UserAggregate;


public class FoundItem:EntityBase,IAggregateRoot
{
  public FoundItem(string itemName, string description, string imageUrl, string location, DateTime lostDate, int userId)
  {
    ItemName = itemName;
    Description = description;
    ImageUrl = imageUrl;
    Location = location;
    LostDate = lostDate;
    UserId = userId;
    Matches = new List<Match>();
  }

  public string ItemName { get; set; }
  public string Description { get; set; }
  public string ImageUrl { get; set; }
  public string Location { get; set; }
  public DateTime LostDate { get; set; }
  public int UserId { get; set; }
  public User User { get; set; } = null!;
  public ICollection<Match> Matches { get; set; }

  public ICollection<Report>? Reports { get; set; }
}
