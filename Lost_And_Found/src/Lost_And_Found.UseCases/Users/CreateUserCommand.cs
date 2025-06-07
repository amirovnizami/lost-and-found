using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_And_Found.UseCases.Users;
public record CreateUserCommand(string Name,string Email,string Password,string PhooneNumber,bool IsAdmin): ICommand<Result<int>>;
