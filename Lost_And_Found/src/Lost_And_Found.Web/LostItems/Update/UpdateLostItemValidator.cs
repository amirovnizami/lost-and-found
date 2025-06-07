using FluentValidation;
using Lost_And_Found.Infrastructure.Data.Config;

namespace Lost_And_Found.Web.LostItems.Update;

public class UpdateLostItemValidator:Validator<UpdateLostItemRequest>
{
  public UpdateLostItemValidator()
  {
    RuleFor(x => x.ItemName)
     .NotEmpty()
     .WithMessage("Name is required.")
     .MinimumLength(2)
     .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
    RuleFor(x => x.ItemId)
      .Must((args, itemId) => args.ItemId == itemId)
      .WithMessage("Route and body Ids must match; cannot update Id of an existing resource.");
  }
}
