using Entities.Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Place
	{
		[Key]
		[JsonProperty("id")]
		public string Id { get; set; } = null!;

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("types")]
		public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();	

		[JsonProperty("nationalPhoneNumber")]
		public string NationalPhoneNumber { get; set; } = string.Empty;

		[JsonProperty("internationalPhoneNumber")]
		public string InternationalPhoneNumber { get; set; } = string.Empty;

		[JsonProperty("formattedAddress")]
		public string FormattedAddress { get; set; } = string.Empty;

		[JsonProperty("addressComponents")]
		public virtual IEnumerable<AddressComponent> AddressComponents { get; set; } = Enumerable.Empty<AddressComponent>();

		[JsonProperty("plusCode")]
		public virtual PlusCode PlusCode { get; set; } = null!;

		[JsonProperty("location")]
		public virtual Location Location { get; set; } = null!;

		[JsonProperty("viewport")]
		public virtual Viewport Viewport { get; set; } = null!;

		[JsonProperty("rating")]
		public double Rating { get; set; }

		[JsonProperty("googleMapsUri")]
		public string GoogleMapsUri { get; set; } = null!;

		[JsonProperty("websiteUri")]
		public string? WebsiteUri { get; set; }

		[JsonProperty("regularOpeningHours")]
		public virtual CurrentOpeningHours RegularOpeningHours { get; set; } = null!;

		[JsonProperty("utcOffsetMinutes")]
		public long UtcOffsetMinutes { get; set; }

		[JsonProperty("adrFormatAddress")]
		public string AdrFormatAddress { get; set; } = string.Empty;

		[JsonProperty("businessStatus")]
		public BusinessStatus BusinessStatus { get; set; }

		[JsonProperty("priceLevel", NullValueHandling = NullValueHandling.Ignore)]
		public PriceLevel PriceLevel { get; set; } = PriceLevel.PRICE_LEVEL_UNSPECIFIED;

		[JsonProperty("userRatingCount")]
		public long UserRatingCount { get; set; }

		[JsonProperty("iconMaskBaseUri")]
		public string? IconMaskBaseUri { get; set; }

		[JsonProperty("iconBackgroundColor")]
		public string IconBackgroundColor { get; set; } = string.Empty;

		[JsonProperty("displayName")]
		public virtual DisplayName DisplayName { get; set; } = null!;

		[JsonProperty("primaryTypeDisplayName")]
		public virtual DisplayName PrimaryTypeDisplayName { get; set; } = null!;

		[JsonProperty("takeout", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Takeout { get; set; }

		[JsonProperty("delivery")]
		public bool Delivery { get; set; }

		[JsonProperty("dineIn")]
		public bool DineIn { get; set; }

		[JsonProperty("curbsidePickup", NullValueHandling = NullValueHandling.Ignore)]
		public bool? CurbsidePickup { get; set; }

		[JsonProperty("reservable")]
		public bool Reservable { get; set; }

		[JsonProperty("servesBreakfast", NullValueHandling = NullValueHandling.Ignore)]
		public bool? ServesBreakfast { get; set; }

		[JsonProperty("servesLunch")]
		public bool ServesLunch { get; set; }

		[JsonProperty("servesDinner")]
		public bool ServesDinner { get; set; }

		[JsonProperty("servesBeer")]
		public bool ServesBeer { get; set; }

		[JsonProperty("servesWine")]
		public bool ServesWine { get; set; }

		[JsonProperty("servesBrunch", NullValueHandling = NullValueHandling.Ignore)]
		public bool? ServesBrunch { get; set; }

		[JsonProperty("servesVegetarianFood", NullValueHandling = NullValueHandling.Ignore)]
		public bool? ServesVegetarianFood { get; set; }

		[JsonProperty("currentOpeningHours")]
		public virtual CurrentOpeningHours CurrentOpeningHours { get; set; } = null!;

		[JsonProperty("primaryType")]
		public string PrimaryType { get; set; } = string.Empty;

		[JsonProperty("shortFormattedAddress")]
		public string ShortFormattedAddress { get; set; } = string.Empty;

		[JsonProperty("editorialSummary", NullValueHandling = NullValueHandling.Ignore)]
		public virtual DisplayName EditorialSummary { get; set; } = null!;

		[JsonProperty("reviews")]
		public virtual IEnumerable<Review> Reviews { get; set; } = Enumerable.Empty<Review>();

		[JsonProperty("photos")]
		public virtual IEnumerable<Photo> Photos { get; set; } = Enumerable.Empty<Photo>();

		[JsonProperty("outdoorSeating")]
		public bool OutdoorSeating { get; set; }

		[JsonProperty("liveMusic")]
		public bool LiveMusic { get; set; }

		[JsonProperty("menuForChildren")]
		public bool MenuForChildren { get; set; }

		[JsonProperty("servesCocktails")]
		public bool ServesCocktails { get; set; }

		[JsonProperty("servesDessert")]
		public bool ServesDessert { get; set; }

		[JsonProperty("servesCoffee")]
		public bool ServesCoffee { get; set; }

		[JsonProperty("goodForChildren", NullValueHandling = NullValueHandling.Ignore)]
		public bool? GoodForChildren { get; set; }

		[JsonProperty("allowsDogs", NullValueHandling = NullValueHandling.Ignore)]
		public bool? AllowsDogs { get; set; }

		[JsonProperty("restroom")]
		public bool Restroom { get; set; }

		[JsonProperty("goodForGroups")]
		public bool GoodForGroups { get; set; }

		[JsonProperty("goodForWatchingSports")]
		public bool GoodForWatchingSports { get; set; }

		[JsonProperty("paymentOptions")]
		public virtual PaymentOptions PaymentOptions { get; set; } = null!;

		[JsonProperty("parkingOptions", NullValueHandling = NullValueHandling.Ignore)]
		public virtual ParkingOptions ParkingOptions { get; set; } = null!;

		[JsonProperty("accessibilityOptions")]
		public virtual AccessibilityOptions AccessibilityOptions { get; set; } = null!;

		[JsonProperty("generativeSummary")]
		public virtual GenerativeSummary GenerativeSummary { get; set; } = null!;

		[JsonProperty("addressDescriptor")]
		public virtual AddressDescriptor AddressDescriptor { get; set; } = null!;

		[JsonProperty("currentSecondaryOpeningHours", NullValueHandling = NullValueHandling.Ignore)]
		public virtual IEnumerable<CurrentOpeningHours> CurrentSecondaryOpeningHours { get; set; } = Enumerable.Empty<CurrentOpeningHours>();

		[JsonProperty("regularSecondaryOpeningHours", NullValueHandling = NullValueHandling.Ignore)]
		public virtual IEnumerable<CurrentOpeningHours> RegularSecondaryOpeningHours { get; set; } = Enumerable.Empty<CurrentOpeningHours>();
	}
}
