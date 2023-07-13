using Acme.API.Entities;
using Acme.Api.Models;

namespace Acme.Api.Repositories.Contracts;

public interface IDrawRepository
{
    Task<Draw> CreateDrawAsync(Draw draw);
    Task<List<Draw>> GetAllDrawsAsync();
    Task<Draw?> GetDrawByIdAsync(int id);
}