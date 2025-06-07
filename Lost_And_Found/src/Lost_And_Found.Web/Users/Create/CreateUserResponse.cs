namespace Lost_And_Found.Web.Users.Create;

public class CreateUserResponse( string Name, string Email,string Password, string PhoneNumber, bool IsAdmin)
{
  public string Name { get; init; } = Name;
  public string Email { get; init; } = Email;
  public string Password { get; init; } = Password;
  public string PhoneNumber { get; init; } = PhoneNumber;
  public bool IsAdmin { get; init; } = IsAdmin;
}
