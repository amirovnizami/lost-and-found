namespace Lost_And_Found.Web.LostItems.Delete;

public class DeleteLostItemRequest
{
  public const string Route = "/lost-items/{ItemId:int}";

  public static string BuildRoute(int itemId) => Route.Replace("ItemId:int", itemId.ToString());

  public int itemId { get; set; }
}
