using Acme.Api.Application;
using Acme.Api.Application.Contracts;
using Acme.API.Entities;
using Acme.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Acme.Shared.Dtos;
using AutoMapper;

namespace Acme.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DrawsController : ControllerBase
{
    private readonly IDrawLogic _drawLogic;
    private readonly IMapper _mapper;

    public DrawsController( IDrawLogic drawLogic, IMapper mapper )
    {
        _drawLogic = drawLogic;
        _mapper = mapper;
    }
    
    [HttpPost]
    public async Task <ActionResult<DrawReadDto>> CreateDrawAsync(DrawCreateDto drawCreateDto)
    {
        var draw = _mapper.Map<Draw>(drawCreateDto);
        var createdDraw = await _drawLogic.CreateDrawAsync(draw);
        return Created($"/Draws/{createdDraw.Id}",createdDraw);
    }

    [HttpGet]
    public async Task<ActionResult<List<DrawReadDto>>> GetAllDrawsAsync()
    {
        var draws = await _drawLogic.GetAllDrawsAsync();
        var drawsDto = _mapper.Map<List<DrawReadDto>>(draws);
        return Ok(drawsDto);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<DrawReadDto>> GetDrawByIdAsync([FromRoute] int id)
    {
        var draw = await _drawLogic.GetDrawByIdAsync(id);
        var drawDto = _mapper.Map<DrawReadDto>(draw);
        return Ok(drawDto);
    }

}
