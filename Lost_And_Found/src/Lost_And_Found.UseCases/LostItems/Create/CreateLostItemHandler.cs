using LostAndFound.Project.Core.LostItemAggregate;

namespace LostAndFound.Project.UseCases.LostItems.Create;

public class CreateLostItemHandler(IRepository<LostItem> repository):ICommandHandler<CreateLostItemCommand,Result<int>>
{
  public async Task<Result<int>> Handle(CreateLostItemCommand request, CancellationToken cancellationToken)
  {
    var newLostItem = new LostItem(request.ItemName, request.Description, request.ImageUrl, request.Location,
      request.LostDate,request.Reward, 1);
    var createdItem = await repository.AddAsync(newLostItem,cancellationToken);
    return createdItem.Id;
  }
}
