
using Lost_And_Found.UseCases.LostItems.Update;

namespace Lost_And_Found.Web.LostItems.Update;

public class Update(IMediator mediator) : Endpoint<UpdateLostItemRequest, UpdateLostItemResponse>
{
  public override void Configure()
  {
    Put(UpdateLostItemRequest.Route);
    AllowAnonymous();
  }
  public override async Task HandleAsync(UpdateLostItemRequest req, CancellationToken ct)
  {
    var command = new UpdateLostItemCommand(req.ItemId, req.ItemName!, req.Description, req.ImageUrl);

    var result = await mediator.Send(command, ct);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(ct);
      return;
    }
    if (result.IsSuccess)
    {
      var dto = result.Value;
      Response = new UpdateLostItemResponse(new LostItemRecord(dto.Id,dto.ItemName, dto.Description,dto.LostDate,dto.Location,dto.IsFound,dto.Reward, dto.ImageUrl));
      return;
    }
  }
}
