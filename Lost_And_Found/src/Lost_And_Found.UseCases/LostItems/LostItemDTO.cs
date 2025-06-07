using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.UseCases.LostItems;
public record LostItemDTO(int Id,string ItemName, string Description , DateTime LostDate,string Location,bool IsFound,string Reward, string ImageUrl)
{

}
