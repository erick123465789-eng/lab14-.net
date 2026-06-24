using lab10erick.Infrastructure.Context;
using laberick10.Domain.Entities;
using MediatR;

namespace lab10erick.Tickets.Commands;

public class CreateTicketHandler : IRequestHandler<CreateTicketCommand, Guid>
{
    private readonly AppDbContext _context;

    public CreateTicketHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
    {
        var ticket = new Ticket
        {
            TicketId = Guid.NewGuid(),
            UserId = request.UserId,
            Title = request.Title,
            Description = request.Description,
            Status = "abierto",
            CreatedAt = DateTime.Now
        };

        _context.Tickets.Add(ticket);
        await _context.SaveChangesAsync(cancellationToken);

        return ticket.TicketId;
    }
}