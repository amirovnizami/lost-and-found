using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.UseCases.LostItems.Delete;
public record DeleteLostItemCommand (int itemId):ICommand<Result>;

