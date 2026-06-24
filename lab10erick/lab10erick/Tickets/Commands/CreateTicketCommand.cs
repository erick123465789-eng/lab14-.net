using MediatR;

namespace lab10erick.Tickets.Commands;

public record CreateTicketCommand(
    Guid UserId,
    string Title,
    string? Description
) : IRequest<Guid>;