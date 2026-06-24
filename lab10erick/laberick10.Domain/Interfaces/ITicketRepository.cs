using laberick10.Domain.Entities;

namespace laberick10.Domain.Interfaces;

public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetAllAsync();
    Task<Ticket?> GetByIdAsync(Guid id);
    Task AddAsync(Ticket ticket);
}