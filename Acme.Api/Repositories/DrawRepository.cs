using Acme.API.Entities;
using Acme.Api.Models;
using Acme.Api.Repositories.Contracts;
using AcmeAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace Acme.Api.Repositories;

public class DrawRepository : IDrawRepository
{
    private readonly AcmeOnlineDbContext _context;

    public DrawRepository(AcmeOnlineDbContext context) // dependency injection
    {
        _context = context;
    }

    public async Task<Draw> CreateDrawAsync(Draw draw)
    {
        await _context.Draws.AddAsync(draw);
        await _context.SaveChangesAsync();
        return draw; // return draw with the ID. Now it is stored in the database
    }

    public async Task<List<Draw>> GetAllDrawsAsync()
    {
        return await _context.Draws.Include(d => d.SerialNumber)
            .ToListAsync(); // there are 2 different tables for Draw and one for serial numbers
    }

    public async Task<Draw?> GetDrawByIdAsync(int id)
    {
        return await _context.Draws.FindAsync(id);
    }
}