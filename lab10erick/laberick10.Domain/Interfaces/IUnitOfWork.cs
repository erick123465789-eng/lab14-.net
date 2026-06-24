namespace laberick10.Domain.Interfaces;

public interface IUnitOfWork
{
    IUserRepository Users { get; }
    ITicketRepository Tickets { get; }
    Task<int> SaveChangesAsync();
}