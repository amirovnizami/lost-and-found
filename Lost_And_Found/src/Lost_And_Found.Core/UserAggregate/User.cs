using LostAndFound.Project.Core.LostItemAggregate;
using LostAndFound.Project.Core.NotificationAggregate;
using LostAndFound.Project.Core.ReportAggregate;

namespace LostAndFound.Project.Core.UserAggregate;

public class User:EntityBase,IAggregateRoot
{
  public User(string name, string email, string passwordHash, string phoneNumber, bool isAdmin)
  {
    Name = name;
    Email = email;
    PasswordHash = passwordHash;
    PhoneNumber = phoneNumber;
    IsAdmin = isAdmin;
  }

  public string Name { get; set; }
  public string Email { get; set; }
  public string PasswordHash { get; set; }
  public string PhoneNumber { get; set; }
  public bool IsAdmin { get; set; } = false;

  public ICollection<LostItem> ?LostItems { get; set; }
  public ICollection<FoundItem>? FoundItems { get; set; }
  public ICollection<Report> ?Reports { get; set; }
  public ICollection<Notification> ?Notifications { get; set; }


}
