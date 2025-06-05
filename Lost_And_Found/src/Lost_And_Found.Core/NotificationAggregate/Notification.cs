using LostAndFound.Project.Core.UserAggregate;

namespace LostAndFound.Project.Core.NotificationAggregate;

public class Notification:EntityBase,IAggregateRoot
{
  public Notification(string message, bool isRead, DateTime createdAt, int userId)
  {
    Message = message;
    IsRead = isRead;
    CreatedAt = createdAt;
    UserId = userId;
  }

  public string Message { get; set; }
  public bool IsRead { get; set; } = false;
  public DateTime CreatedAt { get; set; }
  public int UserId { get; set; }
  public User User { get; set; } = null!;
}
