using System.Xml.Linq;
using Ardalis.GuardClauses;
using LostAndFound.Project.Core.MatchAggregate;
using LostAndFound.Project.Core.ReportAggregate;
using LostAndFound.Project.Core.UserAggregate;

namespace LostAndFound.Project.Core.LostItemAggregate;

public class LostItem : EntityBase, IAggregateRoot
{
  public LostItem(string itemName, string description, string imageUrl, string location, DateTime lostDate, string reward,int userId)
  {
    ItemName = itemName;
    Description = description;
    ImageUrl = imageUrl;
    Location = location;
    LostDate = lostDate;
    UserId = userId;
    Reward = reward;
  }

  public string ItemName { get; set; }
  public string Description { get; set; }
  public string ImageUrl { get; set; }
  public string Location { get; set; }
  public DateTime LostDate { get; set; }
  public string? Reward { get; set; }
  public bool IsFound { get; set; } = false;
  public int UserId { get; set; }

  public User User { get; private set; } = null!;
  public ICollection<Match>? Matches { get; set; }
  public ICollection<Report>? Reports { get; set; }

  public void UpdateDetails(string newName, string newDescription,string newUrl)
  {
    ItemName = newName;
    Description = newDescription;
    ImageUrl = newUrl;
  }

}
