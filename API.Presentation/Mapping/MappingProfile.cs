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

			CreateMap<User, UserProfileDto>()
				.ForMember(dest => dest.username, opt => opt.MapFrom(src => src.UserName))
				.ForMember(dest => dest.email, opt => opt.MapFrom(src => src.Email))
				.ForMember(dest => dest.apiKey, opt => opt.MapFrom(src => src.UserAPIKey));

		}
    }
}
