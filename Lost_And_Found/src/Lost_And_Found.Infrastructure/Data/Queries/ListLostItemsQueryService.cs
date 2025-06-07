using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Lost_And_Found.UseCases.LostItems;
using Lost_And_Found.Web.LostItems.List;

namespace Lost_And_Found.Infrastructure.Data.Queries;
public class ListLostItemsQueryService(AppDbContext dbContext,IMapper mapper) : IListLostItemsQueryService
{
  public async Task<IEnumerable<LostItemDTO>> ListAsync()
  {
    var result = await dbContext.LostItems.ToListAsync();
    var dto = mapper.Map<List<LostItemDTO>>(result);
    return dto;
  }
}
