using Acme.API.Entities;
using Acme.Api.Models;
using Acme.Shared.Dtos;
using AutoMapper;

namespace Acme.Api.Profiles;

public class SerialNumberProfile : Profile
{
    public SerialNumberProfile()
    {
        CreateMap<SerialNumber, SerialNumberReadDto>();
        CreateMap<SerialNumberReadDto, SerialNumber>();
        CreateMap<SerialNumberCreateDto, SerialNumber>();
    }
}