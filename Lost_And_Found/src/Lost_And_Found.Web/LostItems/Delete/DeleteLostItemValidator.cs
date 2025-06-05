using FluentValidation;

namespace Lost_And_Found.Web.LostItems.Delete;

public class DeleteLostItemValidator:Validator<DeleteLostItemRequest>
{
  public DeleteLostItemValidator()
  {
    RuleFor(i => i.itemId).GreaterThan(0);
  }
}
