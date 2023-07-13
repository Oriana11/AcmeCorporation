using Acme.Api.Application.Contracts;
using Acme.API.Entities;
using Acme.Api.Models;
using Acme.Api.Repositories.Contracts;

namespace Acme.Api.Application;

public class DrawLogic : IDrawLogic
{
    private readonly IDrawRepository _drawRepository;

    public DrawLogic( IDrawRepository drawRepository)
    {
        _drawRepository = drawRepository;
    }
    
    public Task<Draw> CreateDrawAsync(Draw draw)
    {
        var createdDraw = _drawRepository.CreateDrawAsync(draw);
        return createdDraw;
    }

    public async Task<List<Draw>> GetAllDrawsAsync()
    {
         return await _drawRepository.GetAllDrawsAsync();
    }

    public async Task<Draw?> GetDrawByIdAsync(int id)
    {
        return await _drawRepository.GetDrawByIdAsync(id);
    }
}