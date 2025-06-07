
using Lost_And_Found.Infrastructure.Data.Queries;
using Lost_And_Found.UseCases.LostItems;
using Lost_And_Found.UseCases.LostItems.List;

namespace Lost_And_Found.Web.LostItems.List;

public class List(IMediator mediator):EndpointWithoutRequest<ListLostItemResponse>
{
  public override void Configure()
  {
    Get("/lost-items");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken ct)
  {
    Result<IEnumerable<LostItemDTO>> result = await mediator.Send(new ListLostItemsQuery(null, null),ct);
    if (result.IsSuccess)
    {
      Response = new ListLostItemResponse
      {
        LostItems = result.Value.Select(item => new LostItemRecord(item.Id, item.ItemName, item.Description, item.LostDate, item.Location, item.IsFound, item.Reward, item.ImageUrl))
      };
    }
  }
}
