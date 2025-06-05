using LostAndFound.Project.Core.LostItemAggregate;

namespace LostAndFound.Project.Core.MatchAggregate;

public class Match:EntityBase,IAggregateRoot
{
  public Match(int lostItemId, int foundItemId,  DateTime createdAt, double matchScore)
  {
    LostItemId = lostItemId;
    FoundItemId = foundItemId;
    CreatedAt = createdAt;
    MatchScore = matchScore;
  }

  public int LostItemId { get; set; }
  public LostItem? LostItem { get; set; }
  
  public int FoundItemId { get; set; }
  public FoundItem ?FoundItem { get; set; }
  
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public double MatchScore { get; set; }
}
