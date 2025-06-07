using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Web.LostItems.Update;

public class UpdateLostItemRequest
{
  public const string Route = "/lost-items/{ItemId:int}";
  public static string BuildRoute(int itemId) => Route.Replace("ItemId:int", itemId.ToString());
  public int ItemId { get; set; }
  [Required]
  public string? ItemName { get; set; }
  public required string Description { get; set; }
  public required string ImageUrl { get; set; }
}
