using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lost_And_Found.Core.LostItemAggregate.Specifications;
using LostAndFound.Project.Core.LostItemAggregate;
using MediatR;

namespace Lost_And_Found.UseCases.LostItems.Get;
public class GetLostItemHandler(IRepository<LostItem> repository) : IQueryHandler<GetLostItemQuery, Result<LostItemDTO>>
{
  public async Task<Result<LostItemDTO>> Handle(GetLostItemQuery request, CancellationToken cancellationToken)
  {
    var spec = new LostItemByIdSpec(request.ItemId);
    var entity = await repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (entity == null) { return Result.NotFound(); }
    return new LostItemDTO(entity.Id,entity.ItemName, entity.Description,entity.LostDate,entity.Location,entity.IsFound,entity.Reward!,entity.ImageUrl);
  }
}
