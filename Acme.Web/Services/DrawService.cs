using System.Text.Json;
using Acme.API.Entities;
using Acme.Shared.Dtos;

namespace Acme.Web.Services;

public class DrawService : IDrawService
{
    private readonly HttpClient _httpClient;

    public DrawService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<DrawReadDto>> GetAllDrawsAsync()
    {
        HttpResponseMessage response = await _httpClient.GetAsync("/Draws");
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        List<DrawReadDto> drawReadDtos = JsonSerializer.Deserialize<List<DrawReadDto>>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return drawReadDtos;
    }

    public async Task<DrawReadDto> CreateDrawAsync(DrawCreateDto drawCreateDto)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/Draws", drawCreateDto);
        string content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(content);
        }

        var drawDto = JsonSerializer.Deserialize<DrawReadDto>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return drawDto;
    }

    public Task<DrawReadDto> GetDrawByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}