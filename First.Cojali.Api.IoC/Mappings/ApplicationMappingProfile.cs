
using AutoMapper;
using First.Cojali.Application.Models;
using First.Cojali.Domain.Entities;

namespace First.Cojali.Api.IoC.Mappings;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
    }
}
