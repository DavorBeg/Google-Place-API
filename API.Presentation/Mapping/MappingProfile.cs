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

			CreateMap<Place, PlaceDto>();
			CreateMap<AccessibilityOptions, AccessibilityOptionsDto>();
			CreateMap<AddressComponent, AddressComponentDto>();
			CreateMap<Area, AreaDto>();
			CreateMap<AuthorAttribution, AuthorAttributionDto>();
			CreateMap<AddressDescriptor, AddressDescriptorDto>();
			CreateMap<Close, CloseDto>();
			CreateMap<Date, DateDto>();
			CreateMap<CurrentOpeningHours, CurrentOpeningHoursDto>();
			CreateMap<DisplayName, DisplayNameDto>();
			CreateMap<GenerativeSummary, GenerativeSummaryDto>();
			CreateMap<Landmark, LandmarkDto>();
			CreateMap<Location, LocationDto>();
			CreateMap<ParkingOptions, ParkingOptionsDto>();
			CreateMap<PaymentOptions, PaymentOptionsDto>();
			CreateMap<Period, PeriodDto>();
			CreateMap<Photo, PhotoDto>();
			CreateMap<Place, PlaceDto>();
			CreateMap<PlusCode, PlusCodeDto>();
			CreateMap<PlusCode, PlusCodeDto>();
			CreateMap<References, ReferencesDto>();
			CreateMap<Review, ReviewDto>();
			CreateMap<Viewport, ViewportDto>();

		}
    }
}
