using lab10erick.Infrastructure.Context;
using laberick10.Domain.Entities;
using laberick10.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab10erick.Infrastructure.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly AppDbContext _context;

    public TicketRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _context.Tickets.ToListAsync();
    }

    public async Task<Ticket?> GetByIdAsync(Guid id)
    {
        return await _context.Tickets.FindAsync(id);
    }

    public async Task AddAsync(Ticket ticket)
    {
        await _context.Tickets.AddAsync(ticket);
    }
}