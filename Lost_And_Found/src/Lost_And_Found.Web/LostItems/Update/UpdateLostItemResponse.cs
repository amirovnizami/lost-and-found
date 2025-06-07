namespace Lost_And_Found.Web.LostItems.Update;

public class UpdateLostItemResponse(LostItemRecord item)
{
  public LostItemRecord LostItem { get; set; } = item;
}
