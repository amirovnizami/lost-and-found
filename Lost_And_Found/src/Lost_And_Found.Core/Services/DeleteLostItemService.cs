using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;
using Lost_And_Found.Core.ContributorAggregate.Events;
using Lost_And_Found.Core.ContributorAggregate;
using Lost_And_Found.Core.Interfaces;
using LostAndFound.Project.Core.LostItemAggregate;

namespace Lost_And_Found.Core.Services;
public class DeleteLostItemService(IRepository<LostItem> repository, IMediator mediator, ILogger<DeleteLostItemService> logger) : IDeleteLostItemService
{
  public async Task<Result> DeleteLostItem(int itemId)
  {
    logger.LogInformation("Deleting Item {itemId}", itemId);
    LostItem? aggregateToDelete = await repository.GetByIdAsync(itemId);
    if (aggregateToDelete == null) return Result.NotFound();

    await repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new ContributorDeletedEvent(itemId);
    await mediator.Publish(domainEvent);

    return Result.Success();
  }
}
