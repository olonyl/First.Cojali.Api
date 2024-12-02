
using AutoMapper;
using First.Cojali.Api.Contracts.Dtos.Request;
using First.Cojali.Api.Contracts.Dtos.Response;
using First.Cojali.Application.Models;

namespace First.Cojali.Api.IoC.Mappings;

public class ApiMappingProfile : Profile
{
    public ApiMappingProfile()
    {
        CreateMap<UserDto, UserResponseDto>();
    }
}
