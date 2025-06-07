
using System.Threading;
using Lost_And_Found.UseCases.LostItems.Delete;

namespace Lost_And_Found.Web.LostItems.Delete;

public class Delete(IMediator mediator) :Endpoint<DeleteLostItemRequest>
{
  public override void Configure()
  {
    Delete(DeleteLostItemRequest.Route);
    AllowAnonymous();
  }
  public async override Task HandleAsync(DeleteLostItemRequest req, CancellationToken ct)
  {
    var command = new DeleteLostItemCommand(req.itemId);
    var result = await mediator.Send(command,ct);
    if (result.Status == ResultStatus.NotFound)
    {
      return;
    }

    if (result.IsSuccess)
    {
      await SendNoContentAsync(ct);
    };
  }
}
