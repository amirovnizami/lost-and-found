using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lost_And_Found.Core.Interfaces;

namespace Lost_And_Found.UseCases.LostItems.Delete;
internal class DeleteLosttemHandler(IDeleteLostItemService deleteLostItemService) : ICommandHandler<DeleteLostItemCommand, Result>
{
  public async Task<Result> Handle(DeleteLostItemCommand request, CancellationToken cancellationToken)

    => await deleteLostItemService.DeleteLostItem(request.itemId);
}
