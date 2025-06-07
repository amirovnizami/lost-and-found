using FluentValidation;

namespace Lost_And_Found.Web.Users.Create;

public class CreateUserValidator:Validator<CreateUserRequest>
{
  public CreateUserValidator()
  {
    RuleFor(u => u.Name)
      .NotEmpty().WithMessage("Name cannot be empty!");
    RuleFor(u => u.Email)
      .NotEmpty()
      .EmailAddress();
    RuleFor(u => u.Password)
    .NotEmpty().WithMessage("Password cannot be empty.")
    .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
    RuleFor(u => u.PhoneNumber)
    .NotEmpty().WithMessage("Phone number is required.")
    .Matches(@"^\d{10}$").WithMessage("Phone number must be exactly 10 digits.");

  }
}
