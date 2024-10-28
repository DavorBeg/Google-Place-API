using Entities.Domain.Enums;
using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record PlaceDto
	{

		public string? Id { get; init; } 
		public string? Name { get; init; }
		public DisplayNameDto? DisplayName { get; init; } 
		public IEnumerable<string>? Types { get; init; }
		public string? PrimaryType { get; init; }
		public string? NationalPhoneNumber { get; init; }
		public string InternationalPhoneNumber { get; set; } = string.Empty;
		public string? FormattedAddress { get; init; }
		public IEnumerable<AddressComponentDto>? AddressComponents { get; init; }
		public PlusCodeDto? PlusCode { get; init; }
		public LocationDto? Location { get; init; }
		public ViewportDto? Viewport { get; init; }
		public double Rating { get; init; }
		public string? GoogleMapsUri { get; init; }
		public string? WebsiteUri { get; init; }
		public CurrentOpeningHoursDto? RegularOpeningHours { get; init; }
		public long UtcOffsetMinutes { get; init; }
		public string AdrFormatAddress { get; init; } = string.Empty;
		public BusinessStatus BusinessStatus { get; init; }
		public PriceLevel PriceLevel { get; init; } = PriceLevel.PRICE_LEVEL_UNSPECIFIED;
		public long UserRatingCount { get; init; }
		public string? IconMaskBaseUri { get; init; }
		public string IconBackgroundColor { get; init; } = string.Empty;
		public DisplayNameDto? PrimaryTypeDisplayName { get; init; }
		public bool Takeout { get; init; }
		public bool Delivery { get; init; }
		public bool DineIn { get; init; }
		public bool CurbsidePickup { get; init; }
		public bool Reservable { get; init; }
		public bool ServesBreakfast { get; init; }
		public bool ServesLunch { get; init; }
		public bool ServesDinner { get; init; }
		public bool ServesBeer { get; init; }
		public bool ServesWine { get; init; }
		public bool ServesBrunch { get; init; }
		public bool ServesVegetarianFood { get; init; }
		public CurrentOpeningHoursDto? CurrentOpeningHours { get; init; }
		public string ShortFormattedAddress { get; init; } = string.Empty;
		public DisplayNameDto? EditorialSummary { get; init; }
		public ICollection<ReviewDto>? Reviews { get; init; }
		public ICollection<PhotoDto>? Photos { get; init; }
		public bool OutdoorSeating { get; init; }
		public bool LiveMusic { get; init; }
		public bool MenuForChildren { get; init; }
		public bool ServesCocktails { get; init; }
		public bool ServesDessert { get; init; }
		public bool ServesCoffee { get; init; }
		public bool? GoodForChildren { get; init; }
		public bool? AllowsDogs { get; init; }
		public bool Restroom { get; init; }
		public bool GoodForGroups { get; init; }
		public bool GoodForWatchingSports { get; init; }
		public PaymentOptionsDto? PaymentOptions { get; init; }
		public ParkingOptionsDto? ParkingOptions { get; init; }
		public AccessibilityOptionsDto? AccessibilityOptions { get; init; }
		public GenerativeSummaryDto? GenerativeSummary { get; init; }
		public AddressDescriptorDto? AddressDescriptor { get; init; }
		public ICollection<CurrentOpeningHoursDto>? CurrentSecondaryOpeningHours { get; init; }
		public ICollection<CurrentOpeningHoursDto>? RegularSecondaryOpeningHours { get; init; }

	}
}
