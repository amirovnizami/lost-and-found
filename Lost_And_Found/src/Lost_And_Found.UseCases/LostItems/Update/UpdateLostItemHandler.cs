using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Project.Core.LostItemAggregate;

namespace Lost_And_Found.UseCases.LostItems.Update;
public class UpdateLostItemHandler(IRepository<LostItem> repository) : ICommandHandler<UpdateLostItemCommand, Result<LostItemDTO>>
{
  public async Task<Result<LostItemDTO>> Handle(UpdateLostItemCommand request, CancellationToken cancellationToken)
  {
    var exisitigItem = await repository.GetByIdAsync(request.ItemId, cancellationToken);

    if (exisitigItem == null) { return Result.NotFound(); }
    exisitigItem.UpdateDetails(request.ItemName, request.Description, request.ImageUrl);

    await repository.UpdateAsync(exisitigItem);
    return new LostItemDTO(exisitigItem.Id,exisitigItem.ItemName, exisitigItem.Description, exisitigItem.LostDate,exisitigItem.Location,exisitigItem.IsFound,exisitigItem.Reward!,exisitigItem.ImageUrl);
  }
}
