using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.UseCases.LostItems.List;
public record ListLostItemsQuery(int? skip, int? take) : IQuery<Result<IEnumerable<LostItemDTO>>>;

