using Acme.API.Entities;
using Acme.Api.Models;

namespace Acme.Api.Application.Contracts;

public interface IDrawLogic
{
    Task<Draw> CreateDrawAsync(Draw draw);
    Task<List<Draw>> GetAllDrawsAsync();
    Task<Draw?> GetDrawByIdAsync(int id);
}