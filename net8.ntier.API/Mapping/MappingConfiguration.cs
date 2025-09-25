using AutoMapper;
using net8.ntier.API.Dtos.Users;
using net8.ntier.Domain.Entities;

namespace net8.ntier.API.Mapping
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            //Create your mappings here
            CreateMap<User, UserCreateRequest>().ReverseMap();
            CreateMap<User, UserUpdateRequest>().ReverseMap();
        }
    }
}
