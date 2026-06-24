using MediatR;

namespace lab10erick.Users.Queries;


public class GetUsersHandler : IRequestHandler<GetUsersQuery, List<string>>
{
    public Task<List<string>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = new List<string>
        {
            "Usuario 1",
            "Usuario 2",
            "Usuario 3"
        };

        return Task.FromResult(users);
    }
}