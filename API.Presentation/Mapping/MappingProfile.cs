using AutoMapper;
using Entities.Domain.Auth;
using Shared.DTOs.Authentication;

namespace API.Presentation.Mapping
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
			CreateMap<UserForRegisterDto, User>()
				.ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.username));

		}
    }
}
