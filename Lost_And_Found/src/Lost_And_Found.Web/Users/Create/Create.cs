
using Lost_And_Found.UseCases.Users;

namespace Lost_And_Found.Web.Users.Create;

public class Create(IMediator mediator) : Endpoint<CreateUserRequest, CreateUserResponse>
{
  public override void Configure()
  {
    Post(CreateUserRequest.Route);
    AllowAnonymous();
  }
  public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
  {
    var command = new CreateUserCommand(req.Name, req.Email, req.Password, req.PhoneNumber, req.IsAdmin);

    var result = await mediator.Send(command, ct);

    if (result.IsSuccess)
    {
      Response = new CreateUserResponse(req.Name, req.Email, req.Password, req.PhoneNumber, req.IsAdmin);
    }
  }
}
