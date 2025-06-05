using FluentValidation;

namespace LostAndFound.Project.Web.LostItems.Create;

public class CreateLostItemValidator:Validator<CreateLostItemRequest>
{
  public CreateLostItemValidator()
  {
    RuleFor(x => x.ItemName)
      .NotEmpty().WithMessage("Item name is required");
    RuleFor(x => x.LostDate)
      .NotEmpty().WithMessage("LostDate is required");
    RuleFor(x=>x.Location)
      .NotEmpty().WithMessage("Location is required");
  }
}
