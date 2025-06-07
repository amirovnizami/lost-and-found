namespace Lost_And_Found.Web.LostItems.GetById;

public class GetByIdLostItemRequest
{
  public const string Route = "/lost-items/{ItemId:int}";

  public static string BuildRoute(int itemId) => Route.Replace("{ItemId:int}", itemId.ToString());

  public int ItemId { get; set; }
}
