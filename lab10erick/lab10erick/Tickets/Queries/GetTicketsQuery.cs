using MediatR;

namespace lab10erick.Tickets.Queries;

public record GetTicketsQuery : IRequest<List<object>>;