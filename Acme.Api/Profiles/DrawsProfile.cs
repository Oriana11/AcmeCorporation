using Acme.API.Entities;
using Acme.Api.Models;
using Acme.Shared.Dtos;

namespace Acme.Api.Profiles;
using AutoMapper;

public class DrawsProfile : Profile
{
    public DrawsProfile()
    {
        CreateMap<Draw, DrawReadDto>();
        CreateMap<DrawReadDto, Draw>();
        CreateMap<DrawCreateDto, Draw>();
    }
}