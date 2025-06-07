using FluentValidation;

namespace Lost_And_Found.Web.LostItems.GetById;

public class GetByIdLostItemValidator : Validator<GetByIdLostItemRequest>
{
  public GetByIdLostItemValidator()
  {
    RuleFor(i => i.ItemId)
      .GreaterThan(0);
  }
}
