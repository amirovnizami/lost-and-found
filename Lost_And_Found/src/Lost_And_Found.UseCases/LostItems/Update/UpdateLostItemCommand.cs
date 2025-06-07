using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.UseCases.LostItems.Update;
public record UpdateLostItemCommand(int ItemId, string ItemName, string Description, string ImageUrl) : ICommand<Result<LostItemDTO>>
{
}
