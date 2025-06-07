using Lost_And_Found.UseCases.LostItems;

namespace Lost_And_Found.Web.LostItems.List;

public interface IListLostItemsQueryService
{
  Task<IEnumerable<LostItemDTO>> ListAsync();
}
