namespace Lost_And_Found.Web.LostItems.List;

public class ListLostItemResponse
{
  public IEnumerable<LostItemRecord> LostItems { get; set; } = [];
}
