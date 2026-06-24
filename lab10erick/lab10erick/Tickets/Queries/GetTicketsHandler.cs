using lab10erick.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace lab10erick.Tickets.Queries;

public class GetTicketsHandler : IRequestHandler<GetTicketsQuery, List<object>>
{
    private readonly AppDbContext _context;

    public GetTicketsHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<object>> Handle(GetTicketsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Tickets
            .Select(t => new
            {
                t.TicketId,
                t.UserId,
                t.Title,
                t.Description,
                t.Status,
                t.CreatedAt,
                t.ClosedAt
            })
            .Cast<object>()
            .ToListAsync(cancellationToken);
    }
}