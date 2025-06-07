using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lost_And_Found.UseCases.Contributors.List;
using Lost_And_Found.Web.LostItems.List;

namespace Lost_And_Found.UseCases.LostItems.List;
public class ListLostItemsHandler(IListLostItemsQueryService query) : IQueryHandler<ListLostItemsQuery, Result<IEnumerable<LostItemDTO>>>
{
  public async Task<Result<IEnumerable<LostItemDTO>>> Handle(ListLostItemsQuery request, CancellationToken cancellationToken)
  {
    var result = await query.ListAsync();

    return Result.Success(result);
  }
}
