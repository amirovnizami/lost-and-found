using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.Core.Interfaces;
public interface IDeleteLostItemService
{
  public Task<Result> DeleteLostItem(int itemId);
}
