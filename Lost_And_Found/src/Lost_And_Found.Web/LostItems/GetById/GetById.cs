
using Lost_And_Found.UseCases.LostItems.Get;

namespace Lost_And_Found.Web.LostItems.GetById;

public class GetById(IMediator mediator) : Endpoint<GetByIdLostItemRequest, LostItemRecord>
{
  public override void Configure()
  {
    Get(GetByIdLostItemRequest.Route);
    AllowAnonymous();
  }

  public async override Task HandleAsync(GetByIdLostItemRequest req, CancellationToken ct)
  {
    var query = new GetLostItemQuery(req.ItemId);

    var result = await mediator.Send(query, ct);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(ct);
      return;
    }
    if (result.IsSuccess)
    {
      Response = new LostItemRecord(result.Value.Id, result.Value.ItemName, result.Value.Description, result.Value.LostDate!, result.Value.Location!, result.Value.IsFound, result.Value.Reward, result.Value.ImageUrl);
      return;
    }
  }
}
