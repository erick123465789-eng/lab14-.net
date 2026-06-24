using lab10erick.Infrastructure.Context;
using laberick10.Domain.Interfaces;

namespace lab10erick.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IUserRepository Users { get; }

    public ITicketRepository Tickets { get; }

    public UnitOfWork(
        AppDbContext context,
        IUserRepository users,
        ITicketRepository tickets)
    {
        _context = context;
        Users = users;
        Tickets = tickets;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}