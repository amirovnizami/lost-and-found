using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Project.Core.LostItemAggregate;

namespace Lost_And_Found.Core.LostItemAggregate.Specifications;
public class LostItemByIdSpec:Specification<LostItem>
{
  public LostItemByIdSpec(int itemId)
  {
    Query.Where(item=>item.Id == itemId);
  }
}
