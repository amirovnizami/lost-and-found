using LostAndFound.Project.Core.LostItemAggregate;
using LostAndFound.Project.Core.UserAggregate;

namespace LostAndFound.Project.Core.ReportAggregate;

public class Report:EntityBase,IAggregateRoot
{
  public Report(string reason, DateTime createdAt, int userId, int? lostItemId, int? foundItemId)
  {
    Reason = reason;
    CreatedAt = createdAt;
    UserId = userId;
    LostItemId = lostItemId;
    FoundItemId = foundItemId;
  }

  public string Reason { get; set; }
  public DateTime CreatedAt { get; set; }

  public int UserId { get; set; }
  public int? LostItemId { get; set; }
  public int? FoundItemId  { get; set; }

  public User User { get; set; } = null!;
  public LostItem? LostItem { get; set; }
  public FoundItem ?FoundItem { get; set; }


}
