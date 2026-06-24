using MediatR;

namespace lab10erick.Users.Queries;

public record GetUsersQuery : IRequest<List<string>>;