using lab10erick.Infrastructure.Context;
using laberick10.Domain.Entities;
using laberick10.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab10erick.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }
}