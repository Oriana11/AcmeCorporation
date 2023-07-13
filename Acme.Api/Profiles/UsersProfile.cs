using Acme.API.Entities;
using Acme.Api.Models;
using Acme.Shared.Dtos;
using AutoMapper;

namespace Acme.Api.Profiles;

public class UsersProfile : Profile
{
    public UsersProfile()
    {
        CreateMap<User, UserReadDto>();
        CreateMap<UserReadDto, User>();
    }
}