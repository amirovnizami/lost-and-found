using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.UseCases.LostItems.Get;
public record GetLostItemQuery(int ItemId) : IQuery<Result<LostItemDTO>>;

