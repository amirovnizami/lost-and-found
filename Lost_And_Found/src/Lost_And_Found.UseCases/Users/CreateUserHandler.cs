using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Project.Core.UserAggregate;

namespace Lost_And_Found.UseCases.Users;
public class CreateUserHandler(IRepository<User> repository) : ICommandHandler<CreateUserCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
  {
    var newUser = new User(request.Name, request.Email, request.Password, request.PhooneNumber, request.IsAdmin);

    var createdUser = await repository.AddAsync(newUser);

    return createdUser.Id;
  }
}
