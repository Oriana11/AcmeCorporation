using Acme.API.Entities;
using Acme.Shared.Dtos;

namespace Acme.Web.Services;

public interface IDrawService
{
   Task<List<DrawReadDto>> GetAllDrawsAsync();
   Task<DrawReadDto> CreateDrawAsync(DrawCreateDto drawCreateDto);
   Task<DrawReadDto> GetDrawByIdAsync(int id);
}