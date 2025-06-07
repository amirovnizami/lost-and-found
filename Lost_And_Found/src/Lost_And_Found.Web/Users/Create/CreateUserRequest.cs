namespace Lost_And_Found.Web.Users.Create;

public class CreateUserRequest
{
  public const string Route = "/users";

  public required string Name { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
  public required string PhoneNumber { get; set; }
  public required bool IsAdmin { get; set; }
}
