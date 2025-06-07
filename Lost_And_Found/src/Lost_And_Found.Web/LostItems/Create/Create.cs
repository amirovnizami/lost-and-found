using LostAndFound.Project.UseCases.LostItems.Create;

namespace LostAndFound.Project.Web.LostItems.Create;

public class Create(IMediator mediator) : Endpoint<CreateLostItemRequest, CreateLostItemResponse>
{
  public override void Configure()
  {
    Post(CreateLostItemRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new CreateLostItemRequest
      {
        ItemName = "Item Name",
        Description = "Description",
        Location = "Location",
        LostDate = DateTime.Now,
        Reward = "100$"
      };
    });
  }

  public override async Task HandleAsync(CreateLostItemRequest request, CancellationToken ct)
  {
    var result =
      await mediator.Send(
        new CreateLostItemCommand(request.ItemName, request.Description!, request.ImageUrl!, request.Location,
          request.LostDate, request.Reward!), ct);
    if (result.IsSuccess)
    {
      Response = new CreateLostItemResponse(request.ItemName, request.Description!, request.Location, request.LostDate, request.Reward);
    }
  }
}
