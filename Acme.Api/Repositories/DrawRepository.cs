using Acme.API.Entities;
using Acme.Api.Models;
using Acme.Api.Repositories.Contracts;
using AcmeAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace Acme.Api.Repositories;

public class DrawRepository : IDrawRepository
{
    private readonly AcmeOnlineDbContext _context;

    public DrawRepository(AcmeOnlineDbContext context)
    {
        _context = context;
    }

    public async Task<Draw> CreateDrawAsync(Draw draw)
    {
        await _context.Draws.AddAsync(draw);
        await _context.SaveChangesAsync();
        return draw;
    }

    public async Task<List<Draw>> GetAllDrawsAsync()
    {
        return await _context.Draws.Include(d => d.SerialNumber)
                                   .ToListAsync();
    }

    public async Task<Draw?> GetDrawByIdAsync(int id)
    {
        return await _context.Draws.FindAsync(id);
    }
}