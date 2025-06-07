using System.ComponentModel.DataAnnotations;

namespace LostAndFound.Project.Web.LostItems.Create;

public class CreateLostItemRequest
{
  public const string Route = "/lost-items";

  public required string ItemName { get; set; }
  public string? Description { get; set; }
  public string? ImageUrl { get; set; }
  public required string Location { get; set; }
  public required DateTime LostDate { get; set; }
  public string? Reward { get; set; }
}
