namespace LostAndFound.Project.UseCases.LostItems.Create;

public  record CreateLostItemCommand(string ItemName,string Description,string ImageUrl,string Location,DateTime LostDate):ICommand<Result<int>>
{
  
}
