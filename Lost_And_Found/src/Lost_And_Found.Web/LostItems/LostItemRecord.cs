namespace Lost_And_Found.Web.LostItems;

public record LostItemRecord(int Id,string ItemName,string Description,DateTime LostDate,string Location,bool IsFound,string Reward,string ImageUrl);

