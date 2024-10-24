using AutoMapper;
using Entities.Domain.Auth;
using Entities.Domain.Google;
using Shared.DTOs.Authentication;
using Shared.DTOs.Google;

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


			CreateMap<Place, PlaceDto>()
				.ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.DisplayName ?? new DisplayName()));


		}
    }
}
